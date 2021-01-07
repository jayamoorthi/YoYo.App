using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Person.Commands.Delete
{
    public class DeletePersonCommand: IRequest<int>
    {
        public int Id { get; set; }

        
    }

public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, int>
{
    private readonly IPersonRepository _personRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public DeletePersonCommandHandler(IPersonRepository personRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _personRepository = personRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<int> Handle(DeletePersonCommand command, CancellationToken cancellationToken)
    {
        var person = await _personRepository.GetByIdAsync(command.Id);
        await _personRepository.DeleteAsync(person);
        await _unitOfWork.Commit(cancellationToken);
        return person.PersonID;
    }
}
}

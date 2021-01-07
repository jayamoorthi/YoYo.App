using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Application.Features.Person.Commands.Create
{
    public partial class CreatePersonCommand : IRequest<int>
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }

    }

    public class PersonValidator : AbstractValidator<CreatePersonCommand>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name).Length(0, 2000);          
        }
    }
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, int>
    {

        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePersonCommandHandler(IPersonRepository personRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _personRepository = personRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = _mapper.Map<YoYo.Domain.Entities.YoYoPerson.Person>(request);
            await _personRepository.InsertAsync(person);
            await _unitOfWork.Commit(cancellationToken);
            return person.PersonID;
        }
    }




}

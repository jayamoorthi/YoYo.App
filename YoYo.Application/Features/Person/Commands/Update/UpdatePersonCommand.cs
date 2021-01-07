using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Person.Commands.Update
{
    public class UpdatePersonCommand : IRequest<int>
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }

        public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, int>
        {
            private readonly IPersonRepository _personRepository;
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _unitOfWork;

            public UpdatePersonCommandHandler(IPersonRepository personRepository, IUnitOfWork unitOfWork, IMapper mapper)
            {
                _personRepository = personRepository;
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }


            public async Task<int> Handle(UpdatePersonCommand command, CancellationToken cancellationToken)
            {
                var person = await _personRepository.GetByIdAsync(command.PersonID);

                if (person == null)
                {
                    //return Result<int>.Fail($"Brand Not Found.");
                    return 0;
                }
                else
                {
                    person.Name = command.Name ?? person.Name;
                    //person.Tax = (command.Tax == 0) ? brand.Tax : command.Tax;
                    //brand.Description = command.Description ?? brand.Description;
                    await _personRepository.UpdateAsync(person);
                    await _unitOfWork.Commit(cancellationToken);
                    return person.PersonID;
                }
            }
        }
    }
}

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Fitness.Commands.Update
{
    public class UpdateFitnessTestCommand : IRequest<int>
    {
        public int FitnessTestID { get; set; }
        public int PersonID { get; set; }
        public string StartDtTime { get; set; }
        public string EndDtTime { get; set; }
        public bool IsWarned { get; set; }
        public bool IsWarning { get; set; }
        public bool IsStoped { get; set; }
        public bool IsStarted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime ModifiedBy { get; set; }

        public class UpdateFitnessTestCommandHandler : IRequestHandler<UpdateFitnessTestCommand, int>
        {

            private readonly IFitnessTestRepository _fitnessTestRepository;
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _unitOfWork;

            public UpdateFitnessTestCommandHandler(IFitnessTestRepository fitnessTestRepository, IUnitOfWork unitOfWork, IMapper mapper)
            {
                _fitnessTestRepository = fitnessTestRepository;
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }


            public async Task<int> Handle(UpdateFitnessTestCommand command, CancellationToken cancellationToken)
            {
                var fitnessTest = await _fitnessTestRepository.GetByIdAsync(command.FitnessTestID);

                if (fitnessTest == null)
                {
                    return 0;
                }
                else
                {
                    fitnessTest.IsStoped = command.IsStoped ? command.IsStoped : fitnessTest.IsStoped;
                    fitnessTest.ModifiedAt = DateTime.UtcNow;               
                    await _fitnessTestRepository.UpdateAsync(fitnessTest);
                    await _unitOfWork.Commit(cancellationToken);
                    return fitnessTest.FitnessTestID;
                }
            }
        }


    }
}

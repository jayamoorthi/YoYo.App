using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Fitness.Commands.Delete
{
    public partial class DeleteFitnessTestCommand : IRequest<int>
    {
        public int FitnessTestID { get; set; }
        public int PersonID { get; set; }

        public class DeleteFitnessTestCommandHandler : IRequestHandler<DeleteFitnessTestCommand, int>
        {

            private readonly IFitnessTestRepository _fitnessTestRepository;
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _unitOfWork;

            public DeleteFitnessTestCommandHandler(IFitnessTestRepository fitnessTestRepository, IUnitOfWork unitOfWork, IMapper mapper)
            {
                _fitnessTestRepository = fitnessTestRepository;
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }


            public async Task<int> Handle(DeleteFitnessTestCommand command, CancellationToken cancellationToken)
            {
                var fitnessTest = await _fitnessTestRepository.GetByIdAsync(command.FitnessTestID);

                if (fitnessTest == null)
                {
                    return 0;
                }
                else
                {
                    fitnessTest.IsDeleted = true;
                    fitnessTest.ModifiedAt = DateTime.UtcNow;
                    await _fitnessTestRepository.UpdateAsync(fitnessTest);
                    await _unitOfWork.Commit(cancellationToken);
                    return fitnessTest.FitnessTestID;
                }
            }
        }

    }
}

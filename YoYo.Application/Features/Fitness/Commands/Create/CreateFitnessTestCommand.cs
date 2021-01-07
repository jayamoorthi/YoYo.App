using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Fitness.Commands.Create
{
    public class CreateFitnessTestCommand : IRequest<int>
    {
        public int FitnessTestID { get; set; }
        public int PersonID { get; set; }
        public string StartDtTime { get; set; }
        public string EndDtTime { get; set; }
        public bool IsWarned { get; set; }
        public bool IsWarning { get; set; }
        public bool IsStoped { get; set; }
        public bool IsStarted { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime ModifiedBy { get; set; }

    }

    public class CreatePersonCommandHandler : IRequestHandler<CreateFitnessTestCommand, int>
    {

        private readonly IFitnessTestRepository _fitnessTestRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePersonCommandHandler(IFitnessTestRepository fitnessTestRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _fitnessTestRepository = fitnessTestRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateFitnessTestCommand request, CancellationToken cancellationToken)
        {
            var fitness = _mapper.Map<YoYo.Domain.Entities.YoYoPerson.FitnessTest>(request);
            await _fitnessTestRepository.InsertAsync(fitness);
            await _unitOfWork.Commit(cancellationToken);
            return fitness.FitnessTestID;
        }
    }
}

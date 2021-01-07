using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Fitness.Queries.GetAll
{
    public class GetAllFitnessQuery :IRequest<List<FitnessResponse>>
    {
        public GetAllFitnessQuery()
        {

        }
    }


    public class GetAllPersonQueryHandler : IRequestHandler<GetAllFitnessQuery, List<FitnessResponse>>
    {
        private readonly IFitnessTestRepository _fitnessTestRepository;
        private readonly IMapper _mapper;

        public GetAllPersonQueryHandler(IFitnessTestRepository fitnessTestRepository, IMapper mapper)
        {
            _fitnessTestRepository = fitnessTestRepository;
            _mapper = mapper;
        }

        public async Task<List<FitnessResponse>> Handle(GetAllFitnessQuery request, CancellationToken cancellationToken)
        {
            var fitnessList = await _fitnessTestRepository.GetListAsync();
            var fitnessResponses = _mapper.Map<List<FitnessResponse>>(fitnessList);
            return fitnessResponses;
        }
    }
}

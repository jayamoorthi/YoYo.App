using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Constansts;
using YoYo.Application.Features.Fitness.Queries.GetAll;

namespace YoYo.Application.Features.Fitness.Queries.GetAllStaticData
{
    public class GetAllFitnessCachedQuery : IRequest<List<FitnessResponse>>
    {
        public GetAllFitnessCachedQuery()
        {

        }
    }

    public class GetAllFitnessCachedQueryHandler : IRequestHandler<GetAllFitnessCachedQuery, List<FitnessResponse>>
    {
        private readonly IMapper _mapper;
        public GetAllFitnessCachedQueryHandler(IMapper mapper)
        {

        }

        public async Task<List<FitnessResponse>> Handle(GetAllFitnessCachedQuery request, CancellationToken cancellationToken)
        {
             return await FitnessTestData.GetFitnessData();
        }
    }

}

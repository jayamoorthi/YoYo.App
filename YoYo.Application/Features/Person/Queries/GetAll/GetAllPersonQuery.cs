using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Person.Queries.GetAll
{
    public class GetAllPersonQuery: IRequest<List<GetAllPersonResponse>>
    {
        public GetAllPersonQuery()
        {

        }
    }

    public class GetAllPersonQueryHandler : IRequestHandler<GetAllPersonQuery,List<GetAllPersonResponse>>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public GetAllPersonQueryHandler(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllPersonResponse>> Handle(GetAllPersonQuery request, CancellationToken cancellationToken)
        {
            var personList = await _personRepository.GetListAsync();
            var mappedBrands = _mapper.Map<List<GetAllPersonResponse>>(personList);
            return mappedBrands;
        }
    }
}

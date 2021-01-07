using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoYo.Application.Features.Person.Queries.GetAll;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Application.Features.Person.Queries.GetById
{
    public class GetPersonByIDQuery : IRequest<GetAllPersonResponse>
    {
        public int Id { get; set; }

        public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIDQuery, GetAllPersonResponse>
        {
            private readonly IPersonRepository _personRespository;
            private readonly IMapper _mapper;

            public GetPersonByIdQueryHandler(IPersonRepository personRepository, IMapper mapper)
            {
                _personRespository = personRepository;
                _mapper = mapper;
            }

            public async Task<GetAllPersonResponse> Handle(GetPersonByIDQuery query, CancellationToken cancellationToken)
            {
                var person = await _personRespository.GetByIdAsync(query.Id);
                var mappedPerson = _mapper.Map<GetAllPersonResponse>(person);
                return mappedPerson;
            }
        }
    }
}

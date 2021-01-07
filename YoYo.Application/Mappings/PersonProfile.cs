using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using YoYo.Application.Features.Person.Commands.Create;
using YoYo.Application.Features.Person.Queries.GetAll;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Application.Mappings
{
    internal class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<CreatePersonCommand, Person>().ReverseMap();
            CreateMap<GetAllPersonResponse, Person>().ReverseMap();
        }
    }
}

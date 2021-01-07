using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using YoYo.Application.Features.Shuttle.Commands.Create;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Application.Mappings
{
    internal class ShuttleProfile : Profile
    {
        public ShuttleProfile()
        {
            CreateMap<CreateShuttleCommand, Shuttle>().ReverseMap();
        }
    }
}

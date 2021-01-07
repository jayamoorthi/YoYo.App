using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using YoYo.Application.Features.Fitness.Commands.Create;
using YoYo.Application.Features.Fitness.Queries.GetAll;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Application.Mappings
{
    internal class FitnessProfile :Profile
    {
        public FitnessProfile()
        {
            CreateMap<CreateFitnessTestCommand, FitnessTest>().ReverseMap();
            CreateMap<FitnessResponse, FitnessTest>().ReverseMap();
        }
    }
}

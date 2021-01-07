using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace YoYo.Application.Features.Shuttle.Queries.GetAllByFitnessTestID
{
    public class GetAllShuttleByFitnessIDQuery : IRequest<int>
    {
        public int PersonID { get; set; }

        public int FitnessID { get; set; }

    }
}

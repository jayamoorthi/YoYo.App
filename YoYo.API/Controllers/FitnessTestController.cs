using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YoYo.Application.Features.Fitness.Commands.Create;
using YoYo.Application.Features.Fitness.Commands.Delete;
using YoYo.Application.Features.Fitness.Commands.Update;
using YoYo.Application.Features.Fitness.Queries.GetAll;

namespace YoYo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FitnessTestController : BaseApiController<FitnessTestController>
    {

        public FitnessTestController(IMediator mediator, ILogger<FitnessTestController> logger):base(mediator, logger)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var fitnesses = await _mediator.Send(new GetAllFitnessQuery());
            return Ok(fitnesses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var fitnesses = await _mediator.Send(new GetAllFitnessQuery());
            if(fitnesses == null)
            {
                return NotFound(); 
            }
            return Ok(fitnesses.FirstOrDefault(x=>x.FitnessTestID == id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateFitnessTestCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateFitnessTestCommand command)
        {
            if (id != command.FitnessTestID)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteFitnessTestCommand { FitnessTestID = id }));
        }

    }
}

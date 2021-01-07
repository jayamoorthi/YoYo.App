using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YoYo.Application.Extensions;
using YoYo.Application.Features.Commands;
using YoYo.Application.Features.Person.Commands.Create;
using YoYo.Application.Features.Person.Commands.Delete;
using YoYo.Application.Features.Person.Commands.Update;
using YoYo.Application.Features.Person.Queries.GetAll;
using YoYo.Application.Features.Person.Queries.GetById;

namespace YoYo.API.Controllers
{
    /// <summary>
    /// This controller use do to CRUD operation person
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : BaseApiController<PersonController>
    {
        public PersonController(IMediator mediator, ILogger<PersonController> logger) : base(mediator, logger)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brands = await _mediator.Send(new GetAllPersonQuery());
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _mediator.Send(new GetPersonByIDQuery() { Id = id });
            return Ok(person);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreatePersonCommand command)
        {
            
            var requestperson = new IdentifiedCommand<CreatePersonCommand,int>(command, new Guid());
            _logger.LogInformation(
                      "----- Sending command: {CommandName} - {IdProperty}: {CommandId} ({@Command})",
                      requestperson.GetGenericTypeName(),
                      nameof(requestperson.Command.Name),
                      requestperson.Command.Name,
                      requestperson);
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdatePersonCommand command)
        {
            if (id != command.PersonID)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeletePersonCommand { Id = id }));
        }
    }
}

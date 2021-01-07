using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YoYo.Application.Features.Fitness.Queries.GetAllStaticData;

namespace YoYo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoyoTestController : BaseApiController<YoyoTestController>
    {
        public YoyoTestController(IMediator mediator, ILogger<YoyoTestController> logger) : base(mediator, logger)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation($"call api url : ${this.HttpContext.Request.Path}/{this.HttpContext.Request.QueryString}");
            var fitnesses = await _mediator.Send(new GetAllFitnessCachedQuery());
            return Ok(fitnesses);
        }

    }
}

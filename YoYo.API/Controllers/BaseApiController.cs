using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace YoYo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController<T> : ControllerBase
    {
        private IMediator _mediatorInstance;
        private ILogger<T> _loggerInstance;

        public BaseApiController(IMediator mediator, ILogger<T> logger)
        {
            _mediatorInstance = mediator;
            _loggerInstance = logger;
        }

        protected IMediator _mediator => _mediatorInstance;
        protected ILogger<T> _logger => _loggerInstance;
        //protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        //protected ILogger<T> _logger => _loggerInstance ??= HttpContext.RequestServices.GetService<ILogger<T>>();
    }
}

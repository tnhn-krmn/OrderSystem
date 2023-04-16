using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderSystemChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public CustomBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}

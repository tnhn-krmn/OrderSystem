using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSystemChallange.Application.Features.Command.Carrier.CreateCarrier;
using OrderSystemChallange.Application.Features.Command.Carrier.DeleteCarrier;
using OrderSystemChallange.Application.Features.Command.Carrier.UpdateCarrier;
using OrderSystemChallange.Application.Features.Queries.Carrier.ListCarrier;

namespace OrderSystemChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarriersController : CustomBaseController
    {
        public CarriersController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet("GetCarrierList")]
        public async Task<IActionResult> Index()
        {
            var response = await _mediator.Send(new ListCarrierQueryRequest());
            return Ok(response);
        }

        [HttpPost("AddCarrier")]
        public async Task<IActionResult> AddCarrier(CreateCarrierCommandRequest createCarrierCommandRequest)
        {
            var response = await base._mediator.Send(createCarrierCommandRequest);
            return Ok(response);
        }

        [HttpPost("DeleteCarrier")]
        public async Task<IActionResult> DeleteCarrier(DeleteCarrierCommandRequest deleteCarrierCommandRequest)
        {
            var response = await base._mediator.Send(deleteCarrierCommandRequest);
            return Ok(response);
        }

        [HttpPost("UpdateCarrier")]
        public async Task<IActionResult> UpdateCarrier(UpdateCarrierCommandRequest updateCarrierCommandRequest)
        {
            var response = await base._mediator.Send(updateCarrierCommandRequest);
            return Ok(response);
        }
    }
}

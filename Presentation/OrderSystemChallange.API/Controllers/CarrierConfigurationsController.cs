using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSystemChallange.Application.Features.Command.CarrierConfiguration.CreateCarrierConfiguration;
using OrderSystemChallange.Application.Features.Command.CarrierConfiguration.DeleteCarrierConfiguration;
using OrderSystemChallange.Application.Features.Command.CarrierConfiguration.UpdateCarrierConfiguration;
using OrderSystemChallange.Application.Features.Queries.CarrierConfiguration.ListCarrierConfiguration;

namespace OrderSystemChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierConfigurationsController : CustomBaseController
    {
        public CarrierConfigurationsController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet("GetCarrierConfigurationList")]
        public async Task<IActionResult> Index()
        {
            var response = await _mediator.Send(new GetListCarrierConfigurationQueryRequest());
            return Ok(response);
        }

        [HttpPost("AddCarrierConfiguration")]
        public async Task<IActionResult> AddCarrier(CreateCarrierConfigurationCommandRequest createCarrierConfigurationCommandRequest)
        {
            var response = await base._mediator.Send(createCarrierConfigurationCommandRequest);
            return Ok(response);
        }

        [HttpPost("DeleteCarrierConfiguration")]
        public async Task<IActionResult> DeleteCarrier(DeleteCarrierConfigurationRequest deleteCarrierConfigurationRequest)
        {
            var response = await base._mediator.Send(deleteCarrierConfigurationRequest);
            return Ok(response);
        }

        [HttpPost("UpdateCarrierConfiguration")]
        public async Task<IActionResult> UpdateCarrier(UpdateCarrierConfigurationCommandRequest updateCarrierConfigurationCommandRequest)
        {
            var response = await base._mediator.Send(updateCarrierConfigurationCommandRequest);
            return Ok(response);
        }

    }
}

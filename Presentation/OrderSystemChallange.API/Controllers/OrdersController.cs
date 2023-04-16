using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSystemChallange.Application.Features.Command.Order.CreateOrder;
using OrderSystemChallange.Application.Features.Command.Order.DeleteOrder;
using OrderSystemChallange.Application.Features.Command.Order.UpdateOrder;
using OrderSystemChallange.Application.Features.Queries.Order.ListOrder;

namespace OrderSystemChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : CustomBaseController
    {
        public OrdersController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet("GetOrderList")]
        public async Task<IActionResult> Index()
        {
            var response = await _mediator.Send(new GetListOrderQueryRequest());
            return Ok(response);
        }

        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(CreateOrderCommandRequest createOrderCommandRequest)
        {
            var response = await base._mediator.Send(createOrderCommandRequest);
            return Ok(response);
        }

        [HttpPost("DeleteOrder")]
        public async Task<IActionResult> DeleteOrder(DeleteOrderCommandRequest deleteOrderCommandRequest)
        {
            var response = await base._mediator.Send(deleteOrderCommandRequest);
            return Ok(response);
        }

        [HttpPost("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommandRequest updateOrderCommandRequest)
        {
            var response = await base._mediator.Send(updateOrderCommandRequest);
            return Ok(response);
        }
    }
}

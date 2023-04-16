using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Order.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly IOrderService _orderService;

        public UpdateOrderCommandHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            UpdateOrderDto updateOrderDto = _mapper.Map<UpdateOrderDto>(request);
            var result = await _orderService.UpdateAsync(updateOrderDto);
            UpdateOrderCommandResponse updateOrderCommandResponse = _mapper.Map<UpdateOrderCommandResponse>(result);
            return updateOrderCommandResponse;
        }
    }
}

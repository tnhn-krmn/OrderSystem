using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Order.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly IOrderService _orderService;

        public DeleteOrderCommandHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            DeleteOrderDto deleteOrder = _mapper.Map<DeleteOrderDto>(request);
            var result = await _orderService.DeleteById(deleteOrder);
            DeleteOrderCommandResponse deleteOrderCommandResponse = _mapper.Map<DeleteOrderCommandResponse>(result);
            return deleteOrderCommandResponse;
        }
    }
}

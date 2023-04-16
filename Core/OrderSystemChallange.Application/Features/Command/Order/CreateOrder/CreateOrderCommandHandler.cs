using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Order.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly IOrderService _orderService;

        public CreateOrderCommandHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {

            AddOrder addOrder = _mapper.Map<AddOrder>(request);
            var result = await _orderService.CreateAsync(addOrder);
            CreateOrderCommandResponse createOrderCommandResponse = _mapper.Map<CreateOrderCommandResponse>(result);

            return createOrderCommandResponse;
        }
    }
}

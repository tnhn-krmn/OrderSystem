using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Queries.Order.ListOrder
{
    public class GetListOrderQueryHandler : IRequestHandler<GetListOrderQueryRequest, GetListOrderQueryResponse>
    {
        protected readonly IOrderService _orderService;

        public GetListOrderQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetListOrderQueryResponse> Handle(GetListOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var results = await _orderService.GetAllAsync();

            return new GetListOrderQueryResponse()
            {
                Data = results.Orders,
                TotalCount = results.TotalOrderCount,
                Message = Conststans.Message.GetAllOrderSuccess,
                Success = true
            };
        }
    }
}

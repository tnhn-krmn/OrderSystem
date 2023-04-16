using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Queries.Order.ListOrder
{
    public class GetListOrderQueryRequest : IRequest<GetListOrderQueryResponse>
    {
    }
}

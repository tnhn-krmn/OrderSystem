using OrderSystemChallange.Application.Features.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Queries.Order.ListOrder
{
    public class GetListOrderQueryResponse : CommandBaseResponse
    {
        public int TotalCount { get; set; }
        public object Data { get; set; }
    }
}

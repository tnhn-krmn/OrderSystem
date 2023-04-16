using OrderSystemChallange.Application.Features.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Queries.Carrier.ListCarrier
{
    public class ListCarrierQueryResponse : CommandBaseResponse
    {
        public object Data { get; set; }
        public int TotalCount { get; set; }
    }
}

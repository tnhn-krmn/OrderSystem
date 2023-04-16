using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.Order
{
    public class GetOrderListResponse : BaseResponse
    {
        public int TotalOrderCount { get; set; }
        public object Orders { get; set; }

    }
}

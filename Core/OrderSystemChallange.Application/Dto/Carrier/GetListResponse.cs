using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.Carrier
{
    public class GetListResponse : BaseResponse
    {
        public int TotalCount { get; set; }
        public object Data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.Carrier
{
    public class GetListHandlerResponse : BaseResponse
    {
        public int TotalCount { get; set; }
        public object Carrier { get; set; }
    }
}

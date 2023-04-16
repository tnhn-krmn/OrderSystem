using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.CarrierConfiguration
{
    public class GetListCarrierConfigurationDto : BaseResponse
    {
        public int TotalCount { get; set; }
        public object CarrierConfiguration { get; set; }
    }
}

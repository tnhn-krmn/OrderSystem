using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.CarrierConfiguration
{
    public class AddCarrierConfigurationDto
    {
        public int CarrierId { get; set; }
        public int MaxDesi { get; set; }
        public int MinDesi { get; set; }
        public decimal Cost { get; set; }
    }
}

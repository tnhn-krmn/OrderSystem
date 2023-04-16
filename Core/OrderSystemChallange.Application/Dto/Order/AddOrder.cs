using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.Order
{
    public class AddOrder
    {
        public int Desi { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal CarrierCost { get; set; }
        public int CarrieId { get; set; }
    }
}

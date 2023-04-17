using OrderSystemChallange.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Domain.Entities
{
    public class CarrierReport : BaseEntity<int>
    {
        public int CarrierId { get; set; }
        public decimal Cost { get; set; }
        public DateTime ReportDate { get; set; }
    }
}

using OrderSystemChallange.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Domain.Entities
{
    public class CarrierConfiguration : BaseEntity<int>
    {
        public int CarrierId { get; set; }
        public int MaxDesi { get; set; }
        public int MinDesi { get; set; }
        public decimal Cost { get; set; }
        public virtual Carrier Carrier { get; set; }
    }
}

using OrderSystemChallange.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Domain.Entities
{
    public class Carrier : BaseEntity<int>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int PlusDesiCost { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CarrierConfiguration> CarrierConfigurations { get; set; }
    }
}

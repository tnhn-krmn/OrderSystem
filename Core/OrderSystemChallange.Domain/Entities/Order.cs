using OrderSystemChallange.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Domain.Entities
{
    public class Order : BaseEntity<int>
    {
        public int Desi { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal CarrierCost { get; set; }
        public int CarrieId { get; set; }

        [ForeignKey("CarrieId")]
        public Carrier Carrier { get; set; }
    }
}

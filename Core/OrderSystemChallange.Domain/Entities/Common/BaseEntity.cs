using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Domain.Entities.Common
{
    public class BaseEntity<Tkey>
    {
        public Tkey Id { get; set; }
    }
}

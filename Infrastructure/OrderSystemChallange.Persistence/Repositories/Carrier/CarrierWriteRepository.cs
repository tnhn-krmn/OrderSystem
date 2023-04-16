using OrderSystemChallange.Application.Repositories.Carrier;
using OrderSystemChallange.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Repositories.Carrier
{
    public class CarrierWriteRepository : WriteRepository<OrderSystemChallange.Domain.Entities.Carrier, int>, ICarrierWriteRepository
    {
        public CarrierWriteRepository(OrderSystemContext context) : base(context)
        {
        }
    }
}

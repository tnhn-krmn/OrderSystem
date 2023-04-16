using OrderSystemChallange.Application.Repositories.Carrier;
using OrderSystemChallange.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Repositories.Carrier
{
    public class CarrierReadRepository : ReadRepository<OrderSystemChallange.Domain.Entities.Carrier, int>, ICarrierReadRepository
    {
        public CarrierReadRepository(OrderSystemContext context) : base(context)
        {
        }
    }
}

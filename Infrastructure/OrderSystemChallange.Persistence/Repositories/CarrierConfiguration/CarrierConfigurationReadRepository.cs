using OrderSystemChallange.Application.Repositories.CarrierConfiguration;
using OrderSystemChallange.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Repositories.CarrierConfiguration
{
    public class CarrierConfigurationReadRepository : ReadRepository<Domain.Entities.CarrierConfiguration, int>, ICarrierConfigurationReadRepository
    {
        public CarrierConfigurationReadRepository(OrderSystemContext context) : base(context)
        {
        }
    }
}

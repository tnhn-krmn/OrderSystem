using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Repositories.CarrierConfiguration
{
    public interface ICarrierConfigurationWriteRepository : IWriteRepository<OrderSystemChallange.Domain.Entities.CarrierConfiguration, int>
    {
    }
}

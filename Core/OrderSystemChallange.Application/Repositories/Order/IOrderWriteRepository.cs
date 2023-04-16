using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Repositories.Order
{
    public interface IOrderWriteRepository : IWriteRepository<OrderSystemChallange.Domain.Entities.Order, int>
    {
    }
}

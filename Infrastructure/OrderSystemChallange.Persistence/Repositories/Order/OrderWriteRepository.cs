using OrderSystemChallange.Application.Repositories.Order;
using OrderSystemChallange.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Repositories.Order
{
    public class OrderWriteRepository : WriteRepository<OrderSystemChallange.Domain.Entities.Order, int>, IOrderWriteRepository
    {
        public OrderWriteRepository(OrderSystemContext context) : base(context)
        {
        }
    }
}

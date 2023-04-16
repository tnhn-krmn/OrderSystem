using OrderSystemChallange.Application.Repositories.Order;
using OrderSystemChallange.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Repositories.Order
{
    public class OrderReadRepository : ReadRepository<Domain.Entities.Order, int>, IOrderReadRepository
    {
        public OrderReadRepository(OrderSystemContext context) : base(context)
        {
        }
    }
}

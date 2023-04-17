using OrderSystemChallange.Application.Repositories.CarrierReport;
using OrderSystemChallange.Application.Repositories.Order;
using OrderSystemChallange.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Repositories.CarrierReport
{
    public class CarrierReportWriteRepository : WriteRepository<OrderSystemChallange.Domain.Entities.CarrierReport, int>, ICarrierReportWriteRepository
    {
        public CarrierReportWriteRepository(OrderSystemContext context) : base(context)
        {
        }
    }
}

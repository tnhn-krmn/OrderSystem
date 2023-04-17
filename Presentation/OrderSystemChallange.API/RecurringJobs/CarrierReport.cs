using OrderSystemChallange.Application.Abstractions.Services;

namespace OrderSystemChallange.API.RecurringJobs
{
    public class CarrierReport
    {
        private readonly IOrderService _orderService;
        private readonly ICarrierReportService _carrierReportService;
        public CarrierReport(IOrderService orderService, ICarrierReportService carrierReportService)
        {
            _carrierReportService = carrierReportService; 
            _orderService = orderService;
        }

        public async Task Process()
        {
            var reportList = await _orderService.GetGroupByAndDateCarrier();
            if(reportList.Count > 0)
            {
               await _carrierReportService.CreateAsync(reportList);
            }

        }
    }
}

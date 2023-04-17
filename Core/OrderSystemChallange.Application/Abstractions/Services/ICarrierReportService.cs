using OrderSystemChallange.Application.Dto.CarrierReport;
using OrderSystemChallange.Application.Utilities.Result.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Abstractions.Services
{
    public interface ICarrierReportService
    {
        Task CreateAsync(List<AddCarrierReportDto> model);
    }
}

using OrderSystemChallange.Application.Dto.CarrierReport;
using OrderSystemChallange.Application.Dto.Order;
using OrderSystemChallange.Application.Utilities.Result.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Abstractions.Services
{
    public interface IOrderService
    {
        Task<IResult> CreateAsync(AddOrder model);
        Task<GetOrderListResponse> GetAllAsync();
        Task<IResult> DeleteById(DeleteOrderDto deleteUser);
        Task<IResult> UpdateAsync(UpdateOrderDto user);
        Task<List<AddCarrierReportDto>> GetGroupByAndDateCarrier();
    }
}

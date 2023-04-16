using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Application.Utilities.Result.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Abstractions.Services
{
    public interface ICarrierService
    {
        Task<IResult> CreateAsync(AddCarrierDto model);
        Task<GetListResponse> GetAllAsync();
        Task<IResult> DeleteById(DeleteCarrierDto deleteUser);
        Task<IResult> UpdateAsync(UpdateCarrierDto user);
    }
}

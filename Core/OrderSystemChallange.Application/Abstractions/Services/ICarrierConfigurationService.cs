using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using OrderSystemChallange.Application.Utilities.Result.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Abstractions.Services
{
    public interface ICarrierConfigurationService
    {
        Task<IResult> CreateAsync(AddCarrierConfigurationDto model);
        Task<GetListCarrierConfigurationDto> GetAllAsync();
        Task<IResult> DeleteById(DeleteCarrierConfigurationDto deleteUser);
        Task<IResult> UpdateAsync(UpdateCarrierConfigurationDto user);
    }
}

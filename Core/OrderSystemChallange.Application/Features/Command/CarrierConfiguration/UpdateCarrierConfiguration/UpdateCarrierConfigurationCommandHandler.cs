using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.CarrierConfiguration.UpdateCarrierConfiguration
{
    public class UpdateCarrierConfigurationCommandHandler : IRequestHandler<UpdateCarrierConfigurationCommandRequest, UpdateCarrierConfigurationCommandResponse>
    {
        protected readonly IMapper _mapperr;
        protected readonly ICarrierConfigurationService _carrierConfigurationService;

        public UpdateCarrierConfigurationCommandHandler(IMapper mapperr, ICarrierConfigurationService carrierConfigurationService)
        {
            _mapperr = mapperr;
            _carrierConfigurationService = carrierConfigurationService;
        }

        public async Task<UpdateCarrierConfigurationCommandResponse> Handle(UpdateCarrierConfigurationCommandRequest request, CancellationToken cancellationToken)
        {
            UpdateCarrierConfigurationDto updateCarrierConfigurationDto = _mapperr.Map<UpdateCarrierConfigurationDto>(request);
            var result = await _carrierConfigurationService.UpdateAsync(updateCarrierConfigurationDto);
            UpdateCarrierConfigurationCommandResponse updateCarrierConfigurationCommandResponse = _mapperr.Map<UpdateCarrierConfigurationCommandResponse>(result);
            return updateCarrierConfigurationCommandResponse;
        }
    }
}

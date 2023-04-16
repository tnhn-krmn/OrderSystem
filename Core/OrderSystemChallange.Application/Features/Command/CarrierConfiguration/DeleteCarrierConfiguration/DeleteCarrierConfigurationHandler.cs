using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.CarrierConfiguration.DeleteCarrierConfiguration
{
    public class DeleteCarrierConfigurationHandler : IRequestHandler<DeleteCarrierConfigurationRequest, DeleteCarrierConfigurationResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly ICarrierConfigurationService _carrierConfigurationService;

        public DeleteCarrierConfigurationHandler(IMapper mapper, ICarrierConfigurationService carrierConfigurationService)
        {
            _mapper = mapper;
            _carrierConfigurationService = carrierConfigurationService;
        }

        public async Task<DeleteCarrierConfigurationResponse> Handle(DeleteCarrierConfigurationRequest request, CancellationToken cancellationToken)
        {
            DeleteCarrierConfigurationDto deleteCarrierConfigurationDto = _mapper.Map<DeleteCarrierConfigurationDto>(request);
            var result = await _carrierConfigurationService.DeleteById(deleteCarrierConfigurationDto);
            DeleteCarrierConfigurationResponse deleteCarrierConfigurationResponse = _mapper.Map<DeleteCarrierConfigurationResponse>(result);
            return deleteCarrierConfigurationResponse;
        }
    }
}

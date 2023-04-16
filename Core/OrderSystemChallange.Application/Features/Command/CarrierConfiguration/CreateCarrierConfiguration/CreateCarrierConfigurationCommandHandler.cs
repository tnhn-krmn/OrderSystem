using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.CarrierConfiguration.CreateCarrierConfiguration
{
    public class CreateCarrierConfigurationCommandHandler : IRequestHandler<CreateCarrierConfigurationCommandRequest, CreateCarrierConfigurationCommandResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly ICarrierConfigurationService _carrierConfigurationService;

        public CreateCarrierConfigurationCommandHandler(IMapper mapper, ICarrierConfigurationService carrierConfigurationService)
        {
            _mapper = mapper;
            _carrierConfigurationService = carrierConfigurationService;
        }

        public async Task<CreateCarrierConfigurationCommandResponse> Handle(CreateCarrierConfigurationCommandRequest request, CancellationToken cancellationToken)
        {
            AddCarrierConfigurationDto addCarrierConfigurationDto = _mapper.Map<AddCarrierConfigurationDto>(request);
            var result = await _carrierConfigurationService.CreateAsync(addCarrierConfigurationDto);
            CreateCarrierConfigurationCommandResponse createCarrierConfigurationCommandResponse = _mapper.Map<CreateCarrierConfigurationCommandResponse>(result);

            return createCarrierConfigurationCommandResponse;
        }
    }
}

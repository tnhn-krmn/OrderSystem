using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.Carrier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Carrier.CreateCarrier
{
    public class CreateCarrierCommandHandler : IRequestHandler<CreateCarrierCommandRequest, CreateCarrierCommandResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly ICarrierService _carrierService;

        public CreateCarrierCommandHandler(ICarrierService carrierService, IMapper mapper)
        {
            _mapper = mapper;
            _carrierService = carrierService;
        }

        public async Task<CreateCarrierCommandResponse> Handle(CreateCarrierCommandRequest request, CancellationToken cancellationToken)
        {
            AddCarrierDto addCarrier = _mapper.Map<AddCarrierDto>(request);
            var result = await _carrierService.CreateAsync(addCarrier);
            CreateCarrierCommandResponse createCarrierCommandResponse = _mapper.Map<CreateCarrierCommandResponse>(result);
            return createCarrierCommandResponse;
        }
    }
}

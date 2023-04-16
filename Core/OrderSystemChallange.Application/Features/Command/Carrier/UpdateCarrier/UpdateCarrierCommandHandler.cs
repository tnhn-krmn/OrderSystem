using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.Carrier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Carrier.UpdateCarrier
{
    public class UpdateCarrierCommandHandler : IRequestHandler<UpdateCarrierCommandRequest, UpdateCarrierCommandResponse>
    {
        protected ICarrierService _carrierService;
        protected readonly IMapper _mapper;

        public UpdateCarrierCommandHandler(ICarrierService carrierService, IMapper mapper)
        {
            _carrierService = carrierService;
            _mapper = mapper;
        }


        public async Task<UpdateCarrierCommandResponse> Handle(UpdateCarrierCommandRequest request, CancellationToken cancellationToken)
        {
            var updateCarrier = _mapper.Map<UpdateCarrierDto>(request);
            var result = await _carrierService.UpdateAsync(updateCarrier);
            UpdateCarrierCommandResponse updateCarrierCommandResponse = _mapper.Map<UpdateCarrierCommandResponse>(result);
            return updateCarrierCommandResponse;

        }
    }
}

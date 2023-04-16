using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.Carrier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Command.Carrier.DeleteCarrier
{
    public class DeleteCarrierCommandHandler : IRequestHandler<DeleteCarrierCommandRequest, DeleteCarrierCommandResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly ICarrierService _carrierService;

        public DeleteCarrierCommandHandler(IMapper mapper, ICarrierService carrierService)
        {
            _mapper = mapper;
            _carrierService = carrierService;
        }

        public async Task<DeleteCarrierCommandResponse> Handle(DeleteCarrierCommandRequest request, CancellationToken cancellationToken)
        {
            DeleteCarrierDto deleteCarrierDto = _mapper.Map<DeleteCarrierDto>(request);
            var result = await _carrierService.DeleteById(deleteCarrierDto);
            DeleteCarrierCommandResponse deleteCarrierCommandResponse = _mapper.Map<DeleteCarrierCommandResponse>(result);
            return deleteCarrierCommandResponse;
        }
    }
}

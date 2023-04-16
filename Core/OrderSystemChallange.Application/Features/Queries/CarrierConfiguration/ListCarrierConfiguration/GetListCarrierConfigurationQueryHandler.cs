using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Queries.CarrierConfiguration.ListCarrierConfiguration
{
    internal class GetListCarrierConfigurationQueryHandler : IRequestHandler<GetListCarrierConfigurationQueryRequest, GetListCarrierConfigurationQueryResponse>
    {
        protected readonly ICarrierConfigurationService _carrierConfigurationService;

        public GetListCarrierConfigurationQueryHandler(ICarrierConfigurationService carrierConfigurationService)
        {
            _carrierConfigurationService = carrierConfigurationService;
        }

        public async Task<GetListCarrierConfigurationQueryResponse> Handle(GetListCarrierConfigurationQueryRequest request, CancellationToken cancellationToken)
        {
            var carrierConfigures = await _carrierConfigurationService.GetAllAsync();

            return new GetListCarrierConfigurationQueryResponse()
            {
                Data = carrierConfigures.CarrierConfiguration,
                TotalCount = carrierConfigures.TotalCount,
                Message = Conststans.Message.GetAllCarrierConfigurationSuccess,
                Success = true
            };
        }
    }
}

using AutoMapper;
using MediatR;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Features.Queries.Carrier.ListCarrier
{
    public class ListCarrierQueriesHandler : IRequestHandler<ListCarrierQueryRequest, ListCarrierQueryResponse>
    {
        protected readonly ICarrierService _carrierService;


        public ListCarrierQueriesHandler(ICarrierService carrierService)
        {
            _carrierService = carrierService;
        }

        public async Task<ListCarrierQueryResponse> Handle(ListCarrierQueryRequest request, CancellationToken cancellationToken)
        {
            var results = await _carrierService.GetAllAsync();

            return new ListCarrierQueryResponse()
            {
                Data = results.Data,
                TotalCount = results.TotalCount,
                Message = Conststans.Message.GetAllCarrierSuccess,
                Success = true
            };
        }
    }
}

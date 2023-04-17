using AutoMapper;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Conststans;
using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Application.Dto.CarrierReport;
using OrderSystemChallange.Application.Repositories.CarrierReport;
using OrderSystemChallange.Application.Utilities.Result.Common;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Services
{
    public class CarrierReportService : ICarrierReportService
    {
        protected readonly ICarrierReportWriteRepository _carrierReportWriteRepository;
        protected readonly IMapper _mapper;

        public CarrierReportService(ICarrierReportWriteRepository carrierReportWriteRepository, IMapper mapper)
        {
            _carrierReportWriteRepository = carrierReportWriteRepository;
            _mapper = mapper;
        }


        public async Task CreateAsync(List<AddCarrierReportDto> model)
        {
            var carrierReport = _mapper.Map<List<CarrierReport>>(model);

            await _carrierReportWriteRepository.AddRangeAsync(carrierReport);
            await _carrierReportWriteRepository.SaveAsync();

        }
    }
}

using AutoMapper;
using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using OrderSystemChallange.Application.Dto.CarrierReport;
using OrderSystemChallange.Application.Dto.Order;
using OrderSystemChallange.Application.Features.Command.Carrier.UpdateCarrier;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.MappingProfiles
{
    public class CarrierReportpProfile : Profile
    {
        public CarrierReportpProfile()
        {
            CreateMap<AddCarrierReportDto, OrderSystemChallange.Domain.Entities.CarrierReport>()
                .ForMember(x => x.CarrierId, opt => opt.MapFrom(x => x.CarrierId))
                .ForMember(x => x.Cost, opt => opt.MapFrom(x => x.Cost))
                .ForMember(x => x.ReportDate, opt => opt.MapFrom(x => x.ReportDate))
            .ReverseMap();

        }
    }
}

using AutoMapper;
using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using OrderSystemChallange.Application.Features.Command.Carrier.CreateCarrier;
using OrderSystemChallange.Application.Features.Command.Carrier.UpdateCarrier;
using OrderSystemChallange.Application.Features.Command.CarrierConfiguration.CreateCarrierConfiguration;
using OrderSystemChallange.Application.Features.Command.CarrierConfiguration.DeleteCarrierConfiguration;
using OrderSystemChallange.Application.Features.Queries.CarrierConfiguration.ListCarrierConfiguration;
using OrderSystemChallange.Application.Utilities.Result.Common;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.MappingProfiles
{
    public class CarrierConfigurationProfile : Profile
    {
        public CarrierConfigurationProfile()
        {
            CreateMap<CreateCarrierConfigurationCommandRequest, AddCarrierConfigurationDto>().ReverseMap();
            CreateMap<AddCarrierConfigurationDto, CarrierConfiguration>().ReverseMap();
            CreateMap<IResult, CreateCarrierCommandResponse>().ReverseMap();

            CreateMap<DeleteCarrierConfigurationRequest, DeleteCarrierConfigurationDto>().ReverseMap();
            CreateMap<DeleteCarrierConfigurationDto, CarrierConfiguration>().ReverseMap();
            CreateMap<IResult, DeleteCarrierConfigurationResponse>().ReverseMap();

            CreateMap<UpdateCarrierCommandRequest, UpdateCarrierConfigurationDto>().ReverseMap();
            CreateMap<UpdateCarrierConfigurationDto, CarrierConfiguration>().ReverseMap();
            CreateMap<IResult, CreateCarrierConfigurationCommandResponse>().ReverseMap();

            CreateMap<CarrierConfiguration, GetCarrierConfigurationListResponse>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.CarrierId, opt => opt.MapFrom(src => src.CarrierId))
           .ForMember(dest => dest.MaxDesi, opt => opt.MapFrom(src => src.MaxDesi))
           .ForMember(dest => dest.MinDesi, opt => opt.MapFrom(src => src.MinDesi))
           .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.Cost))
           .ReverseMap();
        }
    }
}

using AutoMapper;
using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Application.Features.Command.Carrier.CreateCarrier;
using OrderSystemChallange.Application.Features.Command.Carrier.DeleteCarrier;
using OrderSystemChallange.Application.Features.Command.Carrier.UpdateCarrier;
using OrderSystemChallange.Application.Features.Queries.Carrier.ListCarrier;
using OrderSystemChallange.Application.Utilities.Result.Common;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.MappingProfiles
{
    public class CarrierProfile : Profile
    {
        public CarrierProfile()
        {
            CreateMap<CreateCarrierCommandRequest, AddCarrierDto>().ReverseMap();
            CreateMap<AddCarrierDto, Carrier>().ReverseMap();
            CreateMap<IResult, CreateCarrierCommandResponse>().ReverseMap();

            CreateMap<DeleteCarrierCommandRequest, DeleteCarrierDto>().ReverseMap();
            CreateMap<DeleteCarrierDto, Carrier>().ReverseMap();
            CreateMap<IResult, DeleteCarrierCommandResponse>().ReverseMap();

            CreateMap<UpdateCarrierCommandRequest, UpdateCarrierDto>().ReverseMap();
            CreateMap<UpdateCarrierDto, Carrier>().ReverseMap();
            CreateMap<IResult, UpdateCarrierCommandResponse>().ReverseMap();

            CreateMap<Carrier, GetCarrierListResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))    
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))    
            .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))    
            .ForMember(dest => dest.PlusDesiCost, opt => opt.MapFrom(src => src.PlusDesiCost))
            .ReverseMap();

        }
    }
}

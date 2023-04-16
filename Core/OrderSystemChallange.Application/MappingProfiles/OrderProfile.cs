using AutoMapper;
using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Application.Dto.Order;
using OrderSystemChallange.Application.Features.Command.Order.CreateOrder;
using OrderSystemChallange.Application.Features.Command.Order.DeleteOrder;
using OrderSystemChallange.Application.Features.Command.Order.UpdateOrder;
using OrderSystemChallange.Application.Features.Queries.Order.ListOrder;
using OrderSystemChallange.Application.Utilities.Result.Common;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.MappingProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<CreateOrderCommandRequest, AddOrder>().ReverseMap();
            CreateMap<AddOrder, Order>().ReverseMap();
            CreateMap<IResult, CreateOrderCommandResponse>().ReverseMap();

            CreateMap<DeleteOrderCommandRequest, DeleteOrderDto>().ReverseMap();
            CreateMap<DeleteOrderDto, Order>().ReverseMap();
            CreateMap<IResult, DeleteOrderCommandResponse>().ReverseMap();

            CreateMap<UpdateOrderCommandRequest, UpdateOrderDto>().ReverseMap();
            CreateMap<UpdateOrderDto, Order>().ReverseMap();
            CreateMap<IResult, UpdateOrderCommandResponse>().ReverseMap();

            CreateMap<Order, GetOrderDataListResponse>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
          .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
          .ForMember(dest => dest.CarrieId, opt => opt.MapFrom(src => src.CarrieId))
          .ForMember(dest => dest.CarrierCost, opt => opt.MapFrom(src => src.CarrierCost))
          .ForMember(dest => dest.Desi, opt => opt.MapFrom(src => src.Desi))
          .ReverseMap();
        }
    }
}

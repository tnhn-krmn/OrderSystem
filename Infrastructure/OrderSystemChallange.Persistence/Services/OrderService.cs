using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Conststans;
using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using OrderSystemChallange.Application.Dto.Order;
using OrderSystemChallange.Application.Repositories.CarrierConfiguration;
using OrderSystemChallange.Application.Repositories.Order;
using OrderSystemChallange.Application.Utilities.Result.Common;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Services
{
    public class OrderService : IOrderService
    {
        protected IOrderReadRepository _orderReadRepository;
        protected IOrderWriteRepository _orderWriteRepository;
        protected ICarrierConfigurationReadRepository _carrierConfigurationReadRepository;
        protected ICarrierConfigurationWriteRepository _carrierConfigurationWriteRepository;

        protected readonly IMapper _mapper;

        public OrderService(
            IOrderWriteRepository orderWriteRepository,
            IOrderReadRepository orderReadRepository,
            IMapper mapper,
            ICarrierConfigurationWriteRepository carrierConfigurationWriteRepository,
            ICarrierConfigurationReadRepository carrierConfigurationReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
            _mapper = mapper;
            _carrierConfigurationWriteRepository = carrierConfigurationWriteRepository;
            _carrierConfigurationReadRepository = carrierConfigurationReadRepository;
        }

        public async Task<IResult> CreateAsync(AddOrder model)
        {
            var carrierConfiguration = (from con in _carrierConfigurationReadRepository.Table
                                        where con.MinDesi <= model.Desi && model.Desi <= con.MaxDesi
                                        orderby con.Cost ascending
                                        select con).FirstOrDefault();

            var order = _mapper.Map<Order>(model);

            if (carrierConfiguration != null)
            {
                order.CarrieId = carrierConfiguration.CarrierId;
                order.CarrierCost = carrierConfiguration.Cost;
            }
            var IsMaxDesi = (from con in _carrierConfigurationWriteRepository.Table
                                         .Include(x => x.Carrier)
                             where order.Desi > con.MaxDesi
                             orderby con.MaxDesi descending
                             select con).FirstOrDefault();

            if (IsMaxDesi != null)
            {
                var newCost = IsMaxDesi.Cost + (IsMaxDesi.Carrier.PlusDesiCost * (Math.Abs(IsMaxDesi.MaxDesi - IsMaxDesi.MinDesi)));
                order.CarrierCost = newCost;
                order.CarrieId = IsMaxDesi.CarrierId;
            }
            else
            {
                var IsMinDesi = (from con in _carrierConfigurationWriteRepository.Table
                                          .Include(x => x.Carrier)
                                 where order.Desi < con.MinDesi
                                 orderby con.MinDesi
                                 select con).FirstOrDefault();

                order.CarrierCost = IsMinDesi.Cost;
            }




            await _orderWriteRepository.AddAsync(order);
            await _orderWriteRepository.SaveAsync();

            return new SuccessResult(Message.AddedOrderIsSuccess);

        }

        public async Task<IResult> DeleteById(DeleteOrderDto deleteUser)
        {
            var order = await _orderReadRepository.GetSingleAsync(x => x.Id == deleteUser.Id);
            if (order is null) return new ErrorResult(Message.CarrierConfigurationDeletedIsError);

            await _orderWriteRepository.RemoveAsync(deleteUser.Id);
            await _orderWriteRepository.SaveAsync();

            return new SuccessResult(Message.CarrierConfigurationDeletedIsSuccess);
        }

        public async Task<GetOrderListResponse> GetAllAsync()
        {
            var orderCount = _orderReadRepository.GetAll().Count();
            var orders = _orderReadRepository.GetAll().ToList();

            var order = _mapper.Map<List<GetOrderDataListResponse>>(orders);


            return new GetOrderListResponse()
            {
                Message = Message.GetAllOrderSuccess,
                Succeeded = true,
                Orders = order,
                TotalOrderCount = orderCount
            };
        }

        public async Task<IResult> UpdateAsync(UpdateOrderDto order)
        {
            var orderUpdate = await _orderReadRepository.GetByIdAsync(order.Id);

            if (orderUpdate is null) return new ErrorResult(Message.CarrierConfigurationIsUpdatedFail);

            orderUpdate = _mapper.Map<Order>(order);

            _orderWriteRepository.Update(orderUpdate);
            _orderWriteRepository.SaveAsync();

            return new SuccessResult(Message.CarrierConfigurationIsUpdatedSuccess);
        }
    }
}

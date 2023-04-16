using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Conststans;
using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Application.Repositories.Carrier;
using OrderSystemChallange.Application.Utilities.Result.Common;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Services
{
    public class CarrierService : ICarrierService
    {
        protected ICarrierReadRepository _carrierReadRepository;
        protected ICarrierWriteRepository _carrierWriteRepository;
        private readonly IMapper _mapper;

        public CarrierService(ICarrierReadRepository carrierReadRepository, ICarrierWriteRepository carrierWriteRepository, IMapper mapper)
        {
            _carrierReadRepository = carrierReadRepository;
            _carrierWriteRepository = carrierWriteRepository;
            _mapper = mapper;
        }

        public async Task<IResult> CreateAsync(AddCarrierDto model)
        {
            Carrier carrier = _mapper.Map<Carrier>(model);
            await _carrierWriteRepository.AddAsync(carrier);
            var result = await _carrierWriteRepository.SaveAsync();
            if (result <= 0)
            {
                return new ErrorResult(Message.CarrierConfigurationCreatedIsError);
            }
            return new SuccessResult(Message.CarrierConfigurationCreatedSuccess);
        }

        public async Task<IResult> DeleteById(DeleteCarrierDto deleteUser)
        {
            var carrier = await _carrierReadRepository.GetSingleAsync(x => x.Id == deleteUser.Id);
            if (carrier is null) return new ErrorResult(Message.CarrierConfigurationDeletedIsError);

            await _carrierWriteRepository.RemoveAsync(deleteUser.Id);
            await _carrierWriteRepository.SaveAsync();

            return new SuccessResult(Message.CarrierConfigurationDeletedIsSuccess);
        }

        public async Task<GetListResponse> GetAllAsync()
        {
            var totalCount = await _carrierReadRepository.GetAll().CountAsync();
            var carriers = await _carrierReadRepository.GetAll().ToListAsync();

            var carrier = _mapper.Map<List<GetCarrierListResponse>>(carriers);
            return new GetListResponse()
            {
                Message = Message.GetAllCarrierSuccess,
                Succeeded = true,
                Data = carrier,
                TotalCount = totalCount
            };
        }

        public async Task<IResult> UpdateAsync(UpdateCarrierDto user)
        {
            var carrier = await _carrierReadRepository.GetByIdAsync(user.Id,false);
            if (carrier is null) return new ErrorResult(Message.CarrierConfigurationIsNotFound);

            carrier = _mapper.Map<Carrier>(user);

           _carrierWriteRepository.Update(carrier);
           var result = await _carrierWriteRepository.SaveAsync();

            if(result > 0)
            { 
            return new SuccessResult(Message.CarrierConfigurationIsUpdatedSuccess);
            }

            return new ErrorResult(Message.CarrierConfigurationIsUpdatedFail);

        }
    }
}

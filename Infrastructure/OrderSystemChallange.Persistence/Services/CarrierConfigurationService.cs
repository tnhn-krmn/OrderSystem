using AutoMapper;
using OrderSystemChallange.Application.Abstractions.Services;
using OrderSystemChallange.Application.Conststans;
using OrderSystemChallange.Application.Dto.Carrier;
using OrderSystemChallange.Application.Dto.CarrierConfiguration;
using OrderSystemChallange.Application.Repositories.CarrierConfiguration;
using OrderSystemChallange.Application.Utilities.Result.Common;
using OrderSystemChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence.Services
{
    public class CarrierConfigurationService : ICarrierConfigurationService
    {
        protected ICarrierConfigurationReadRepository _carrierConfigurationReadRepository;
        protected ICarrierConfigurationWriteRepository _carrierConfigurationWriteRepository;
        private readonly IMapper _mapper;

        public CarrierConfigurationService(IMapper mapper, ICarrierConfigurationReadRepository carrierConfigurationReadRepository, ICarrierConfigurationWriteRepository carrierConfigurationWriteRepository)
        {
            _mapper = mapper;
            _carrierConfigurationReadRepository = carrierConfigurationReadRepository;
            _carrierConfigurationWriteRepository = carrierConfigurationWriteRepository;
        }

        public async Task<IResult> CreateAsync(AddCarrierConfigurationDto model)
        {
            CarrierConfiguration carrier = _mapper.Map<CarrierConfiguration>(model);
            await _carrierConfigurationWriteRepository.AddAsync(carrier);
            var result = await _carrierConfigurationWriteRepository.SaveAsync();
            if (result < 0)
            {
                return new ErrorResult(Message.CarrierConfigurationCreatedIsError);
            }
            return new SuccessResult(Message.CarrierConfigurationCreatedSuccess);
        }

        public async Task<IResult> DeleteById(DeleteCarrierConfigurationDto deleteUser)
        {
            var carrier = await _carrierConfigurationReadRepository.GetSingleAsync(x => x.Id == deleteUser.Id);
            if (carrier is null) return new ErrorResult(Message.CarrierConfigurationDeletedIsError);

            await _carrierConfigurationWriteRepository.RemoveAsync(deleteUser.Id);
            await _carrierConfigurationWriteRepository.SaveAsync();

            return new SuccessResult(Message.CarrierConfigurationDeletedIsSuccess);
        }

        public async Task<GetListCarrierConfigurationDto> GetAllAsync()
        {
            var totalCount = _carrierConfigurationReadRepository.GetAll().Count();
            var carriers = _carrierConfigurationReadRepository.GetAll().ToList();

            var carrier = _mapper.Map<List<GetCarrierConfigurationListResponse>>(carriers);


            return new GetListCarrierConfigurationDto()
            {
                Message = Message.GetAllCarrierConfigurationSuccess,
                Succeeded = true,
                CarrierConfiguration = carrier,
                TotalCount = totalCount
            };
        }

        public async Task<IResult> UpdateAsync(UpdateCarrierConfigurationDto user)
        {
            var carrier = await _carrierConfigurationReadRepository.GetByIdAsync(user.Id);
            if (carrier is null) return new ErrorResult(Message.CarrierConfigurationIsUpdatedFail);

            carrier = _mapper.Map<CarrierConfiguration>(user);

            _carrierConfigurationWriteRepository.Update(carrier);
            _carrierConfigurationWriteRepository.SaveAsync();

            return new SuccessResult(Message.CarrierConfigurationIsUpdatedSuccess);
        }
    }
}

using FluentValidation;
using OrderSystemChallange.Application.Features.Command.CarrierConfiguration.CreateCarrierConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Validators.CarrierConfiguration
{
    public class CreateCarrierConfigurationCommandValidator : AbstractValidator<CreateCarrierConfigurationCommandRequest>
    {
        public CreateCarrierConfigurationCommandValidator()
        {
            RuleFor(c => c.CarrierId)
                .GreaterThan(0)
                    .WithMessage("Girilen değer sıfırdan büyük olmalı")
                .NotEmpty()
                .NotNull()
                .WithMessage("Boş geçilemez");

            RuleFor(c => c.MaxDesi)
                .GreaterThan(0)
                    .WithMessage("Girilen değer sıfırdan büyük olmalı")
               .NotEmpty()
               .NotNull()
               .WithMessage("Boş geçilemez");

            RuleFor(c => c.MinDesi)
                .GreaterThan(0)
                    .WithMessage("Girilen değer sıfırdan büyük olmalı")
               .NotEmpty()
               .NotNull()
               .WithMessage("Boş geçilemez");

            RuleFor(c => c.Cost)
                .GreaterThan(0)
                    .WithMessage("Girilen değer sıfırdan büyük olmalı")
               .NotEmpty()
               .NotNull()
                    .WithMessage("Boş geçilemez");
        }
    }
}

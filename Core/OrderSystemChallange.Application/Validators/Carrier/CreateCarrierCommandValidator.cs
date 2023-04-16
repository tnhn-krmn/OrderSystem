using FluentValidation;
using OrderSystemChallange.Application.Features.Command.Carrier.CreateCarrier;
using OrderSystemChallange.Application.Features.Command.Order.CreateOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Validators.Carrier
{
    public class CreateCarrierCommandValidator : AbstractValidator<CreateCarrierCommandRequest>
    {
        public CreateCarrierCommandValidator()
        {
            RuleFor(c => c.IsActive)
                .NotEmpty()
                .NotNull()
                .WithMessage("Boş geçilemez");

            RuleFor(c => c.Name)
               .NotEmpty()
               .NotNull()
               .WithMessage("Boş geçilemez");

            RuleFor(c => c.PlusDesiCost)
                .GreaterThan(0)
                    .WithMessage("Girilen değer sıfırdan büyük olmalı")
               .NotEmpty()
               .NotNull()
                    .WithMessage("Boş geçilemez");

        }
    }
}

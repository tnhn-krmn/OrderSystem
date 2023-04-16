using FluentValidation;
using OrderSystemChallange.Application.Features.Command.Order.CreateOrder;
using OrderSystemChallange.Application.Features.Command.Order.UpdateOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Validators.Order
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommandRequest>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(c => c.Id)
             .GreaterThan(0)
                 .WithMessage("Girilen değer sıfırdan büyük olmalı")
             .NotEmpty()
             .NotNull()
             .WithMessage("Boş geçilemez");

            RuleFor(c => c.CarrieId)
             .GreaterThan(0)
                 .WithMessage("Girilen değer sıfırdan büyük olmalı")
             .NotEmpty()
             .NotNull()
             .WithMessage("Boş geçilemez");

            RuleFor(c => c.CarrierCost)
                .GreaterThan(0)
                    .WithMessage("Girilen değer sıfırdan büyük olmalı")
               .NotEmpty()
               .NotNull()
               .WithMessage("Boş geçilemez");

            RuleFor(c => c.OrderDate)
               .NotEmpty()
               .NotNull()
               .WithMessage("Boş geçilemez");

            RuleFor(c => c.Desi)
                .GreaterThan(0)
                    .WithMessage("Girilen değer sıfırdan büyük olmalı")
               .NotEmpty()
               .NotNull()
                    .WithMessage("Boş geçilemez");
        }
    }
}

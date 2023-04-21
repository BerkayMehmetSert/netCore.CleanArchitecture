using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using static Application.Features.Products.Create.CreateProductMessage;
namespace Application.Features.Products.Create
{
    public sealed class CreateProductsValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductsValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(ProductNameIsRequired);
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage(ProductDescriptionIsRequired);
            RuleFor(x => x.Price)
                .NotEmpty()
                .WithMessage(ProductPriceIsRequired);
            RuleFor(x=>x.Price)
                .GreaterThan(0)
                .WithMessage(ProductPriceMustBeGreaterThanZero);
        }
    }
}

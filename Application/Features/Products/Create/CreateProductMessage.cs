using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Create
{
    public static class CreateProductMessage
    {
        public const string ProductNameIsRequired = "Product name is required.";
        public const string ProductDescriptionIsRequired = "Product description is required.";
        public const string ProductPriceIsRequired = "Product price is required.";
        public const string ProductPriceMustBeGreaterThanZero = "Product price must be greater than zero.";
    }
}

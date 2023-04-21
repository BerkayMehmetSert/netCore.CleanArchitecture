using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Products.Create
{
    public sealed record CreateProductRequest(string Name, string Description, double Price) : IRequest<CreateProductResponse>;
}

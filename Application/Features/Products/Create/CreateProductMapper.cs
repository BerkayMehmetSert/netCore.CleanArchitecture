using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Products.Create
{
    public sealed class CreateProductMapper : Profile
    {
        public CreateProductMapper()
        {
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, CreateProductResponse>().ReverseMap();
        }
    }
}

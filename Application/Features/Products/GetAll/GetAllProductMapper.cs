using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Products.GetAll
{
    public sealed class GetAllProductMapper : Profile
    {
        public GetAllProductMapper()
        {
            CreateMap<Product, GetAllProductResponse>().ReverseMap();
        }
    }
}

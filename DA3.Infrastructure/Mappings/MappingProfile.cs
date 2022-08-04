using AutoMapper;
using DA3.DAL.Domain;
using DA3.Service.Dto;
using DA3.Service.Request;

namespace DA3.Infrastructure.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Product, Product>();

            this.CreateMap<CreateProductRequest, Product>();
            this.CreateMap<Product, ProductDto>();
            this.CreateMap<UpdateProductRequest, Product>();
        }
    }
}

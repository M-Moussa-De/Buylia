using AutoMapper;
using Buylia.DTO.Product;
using Buylia.Model;

namespace Buylia.Application.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}

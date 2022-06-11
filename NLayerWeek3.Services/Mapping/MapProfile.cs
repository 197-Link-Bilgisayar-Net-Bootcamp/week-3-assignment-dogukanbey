using AutoMapper;
using NLayerWeek3.Data.Models;
using NLayerWeek3.Services.Dtos;


namespace NLayerWeek3.Services.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();


        }
    }
}

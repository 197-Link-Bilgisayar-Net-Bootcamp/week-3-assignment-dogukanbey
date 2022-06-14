using AutoMapper;
using week_3_assignment.Data.Models;
using week_3_assignment.Service.Services.Dtos;


namespace week_3_assignment.Service.Mapping
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

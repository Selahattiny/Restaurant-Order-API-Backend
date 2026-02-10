using ApiProjeKampi.WebApi.Dtos.FeatureDtos;
using ApiProjeKampi.WebApi.Dtos.ProductDto;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;

namespace ApiProjeKampi.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpDateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultFeatureDto>().ReverseMap();
            CreateMap<Message, CreateFeatureDto>().ReverseMap();
            CreateMap<Message, UpDateFeatureDto>().ReverseMap();
            CreateMap<Message, GetByIdFeatureDto>().ReverseMap();  

            CreateMap<Product, CreateProductDto>().ReverseMap();    
            CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x => x.CategoryName, y=> y.MapFrom(z => z.Category.CategoryName)).ReverseMap();
        }
    }
    
    
}

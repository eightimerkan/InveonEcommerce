using AutoMapper;
using Inveon.Services.ProductAPI.Dto;
using Inveon.Services.ProductAPI.Models;


namespace Inveon.Services.ProductAPI
{
    public class MappingConfig : Profile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
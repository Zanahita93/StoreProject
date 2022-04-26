using AutoMapper;
using ProductModels.ProductDtoModels;
using ProductModels.ProductEntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModels
{

    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<AddProductDto, Product>().ReverseMap();
            });
            return mappingConfig;

        }

    }
}

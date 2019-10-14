using AutoMapper;
using Rarin_Technologies_API.Entities;
using Rarin_Technologies_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, InCategoryDTO>();
            CreateMap<Product, InProductDTO>();
            

            CreateMap<Category, OutCategoryDTO>();
            CreateMap<Product, OutProductDTO>();
      
        }
    }
}

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
            CreateMap<Voucher,InVoucherDTO>();
            CreateMap <ShoppingCar, InShoppingCarDTO>();
            CreateMap<Client, InClientDTO>();
            CreateMap<Voucher, InVoucherDTO>();
            CreateMap<Item, InItemDTO>();
            CreateMap<Person, InPersonDTO>();

            CreateMap<Category, OutCategoryDTO>();
            CreateMap<Product, OutProductDTO>();
            CreateMap<Voucher, OutVoucherDTO>();
            CreateMap<ShoppingCar, OutShoppingCarDTO>();
            CreateMap<Client, OutClientDTO>();
            CreateMap<Voucher, OutVoucherDTO>();
            CreateMap<Item, OutItemDTO>();
        }
    }
}

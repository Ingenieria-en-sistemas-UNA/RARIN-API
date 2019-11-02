using AutoMapper;
using Rarin_Technologies_API.Entities;
using Rarin_Technologies_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<InProductDTO, Product>();
            CreateMap<InCategoryDTO, Category>();
            CreateMap<InVoucherDTO, Voucher>();
            CreateMap<InShoppingCarDTO, ShoppingCar>();
            CreateMap<InClientDTO, Client>();
            CreateMap<InVoucherDTO, Voucher>();
            CreateMap<InItemDTO, Item>();

            CreateMap<OutCategoryDTO, Category>();
            CreateMap<OutProductDTO, Product>();
            CreateMap<OutVoucherDTO,Voucher>();
            CreateMap<OutShoppingCarDTO, ShoppingCar>();
            CreateMap<OutClientDTO, Client>();
            CreateMap<OutVoucherDTO, Voucher>();
            CreateMap<OutItemDTO, Item>();

        }
    }
}

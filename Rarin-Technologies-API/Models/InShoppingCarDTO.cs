using Rarin_Technologies_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class InShoppingCarDTO
    {
        public int PersonId { set; get; }
        public int ProductId { set; get; }
        public Person Person { set; get; }
        public List<InProductDTO> Products { set; get; }
    }
}

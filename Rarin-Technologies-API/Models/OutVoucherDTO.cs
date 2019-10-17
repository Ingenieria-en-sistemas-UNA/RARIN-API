using Rarin_Technologies_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class OutVoucherDTO
    {
        public OutClientDTO Client { get; set; }
        public List<OutProductDTO> Products { get; set; }
    }
}

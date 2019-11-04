using Rarin_Technologies_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class OutClientDTO
    {
        public int Id { get; set; }
        public List<OutVoucherDTO> Vouchers { get; set; }
        public Person Person { get; set; }
    }
}

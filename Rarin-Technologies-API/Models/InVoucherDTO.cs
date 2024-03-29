﻿using Rarin_Technologies_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class InVoucherDTO
    {
        public List<InProductDTO> Products { get; set; }
        public int ClientId { get; set; }
        public string Detail { get; set; }
    }
}

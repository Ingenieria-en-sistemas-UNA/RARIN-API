﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class OutItemDTO
    {
        public int Id { get; set; }
        public OutProductDTO Product { get; set; }
        public int Cant { get; set; }
    }
}
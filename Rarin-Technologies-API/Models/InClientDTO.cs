﻿using Rarin_Technologies_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class InClientDTO
    {
        public Person Person { get; set; }
        public InShoppingCarDTO ShoppingCar { get; set; }
    }
}

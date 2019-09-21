using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Category Category { get; set; }
    }
}
    
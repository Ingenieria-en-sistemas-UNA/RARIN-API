using System;
using System.Collections.Generic;


namespace Rarin_Technologies_API.Entities
{
    public class ShoppingCar
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int PersonId { set; get; }
        public Person Person { set; get; }
        public List<Product> Products { set; get; }
    }
}

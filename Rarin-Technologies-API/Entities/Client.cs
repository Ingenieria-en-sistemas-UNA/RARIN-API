using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int ShoppingCarId { get; set; }
        [ForeignKey("ShoppingCarId")]
        public ShoppingCar ShoppingCar { get; set; }
        public List<Voucher> Vouchers { get; set; }
    }
}

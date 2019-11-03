using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Entities
{
    public class Voucher
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }
        public int ClientId { get; set; }
        public Client Client { set; get; }
        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}

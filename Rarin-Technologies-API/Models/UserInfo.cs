using Rarin_Technologies_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class UserInfo
    {
        public string Email { set; get; }
        public string Password { get; set; }
        public Client Client { get; set; }

    }
}

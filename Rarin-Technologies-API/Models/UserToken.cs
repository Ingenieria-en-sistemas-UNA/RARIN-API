using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class UserToken
    {
        public string Token { set; get; }
        public DateTime Expiration { set; get; }

    }
}

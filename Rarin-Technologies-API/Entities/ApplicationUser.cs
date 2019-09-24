using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}

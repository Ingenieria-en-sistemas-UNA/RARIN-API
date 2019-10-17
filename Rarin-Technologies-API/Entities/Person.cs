using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Dni { get; set; }     
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}

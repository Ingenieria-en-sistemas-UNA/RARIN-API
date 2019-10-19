using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rarin_Technologies_API.Models
{
    public class CardDTO
    {
        public string NameOfCar { get; set; }
        public int NumberOfDoors { get; set; }
        public DateTime FirstRegistration { get; set; }
        public double MaxSpeed { get; set; }
    }
}

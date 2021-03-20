using CitiesAPI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesAPI.Models
{
    public class Restaraunt
    {
        public City City { get; set;  }
        public string Name { get; set; }
        public string Address { get; set; }
        public RestarauntType type { get; set; }
    }
}

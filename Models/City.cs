using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesAPI.Models
{
    public class City
    {
        public Country Country { set; get; }
        public string Name { set; get; }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
    }
}

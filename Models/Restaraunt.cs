using CitiesAPI.Helper;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesAPI.Models
{
    public class Restaraunt
    {
        public int ID { get; set; }
        public int CityID { get; set;  }
        public string Name { get; set; }
        public string Address { get; set; }
        public RestarauntType Type { get; set; }
    }
}

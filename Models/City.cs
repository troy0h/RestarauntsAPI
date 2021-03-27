using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesAPI.Models
{
    public class City
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}

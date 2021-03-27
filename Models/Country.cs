using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesAPI.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CallCode { get; set; }
        public string Currency { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.API.DTO
{
    public class CarDto
    {
        public CarDto() { }
        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string countryManufactured { get; set; }
        public string colour { get; set; }
        public decimal price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
   public class Car
    {
        public int CarId { get; set; }
        public string BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int km {  get; set; }
        public string  Transmisson { get; set; }
        public byte Seat { get; set; }
        public byte Luggage {  get; set; }
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }
        public List<Feature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }



    }
}

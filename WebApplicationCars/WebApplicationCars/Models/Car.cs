using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCars.Models
{
    public class Car
    {
        public int ID { get; set; }
        [StringLength(15)]
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ImgURL { get; set; }
        public int Mileage { get; set; }
        public CategoryType Category { get; set; }
        public EngineType Engine { get; set; }
        public int Power { get; set; }
        public TransmissionType Transmission { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }
}

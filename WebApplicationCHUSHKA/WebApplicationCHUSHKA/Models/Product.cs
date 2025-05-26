using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCHUSHKA.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public TypeProduct Type { get; set; }
        public string ImageURL { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}

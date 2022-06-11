using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerWeek3.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public Category? Category { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public ProductFeature? ProductFeature { get; set; }
    }
}
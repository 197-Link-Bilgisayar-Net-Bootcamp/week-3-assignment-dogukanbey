using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_assignment.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public virtual Category? Category { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public virtual ProductFeature? ProductFeature { get; set; }
    }
}
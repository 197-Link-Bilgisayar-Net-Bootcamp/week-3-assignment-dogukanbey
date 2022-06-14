using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_assignment.Service.Services.Dtos
{
    public class ProductDto
    {
       
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }


    }
}

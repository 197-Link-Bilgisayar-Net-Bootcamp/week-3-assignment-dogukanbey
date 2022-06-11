using NLayerWeek3.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerWeek3.Data.Repositories
{
 
       public class ProductFeatureRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
    {
        public ProductFeatureRepository(AppDbContext context) : base(context)
        {
        }
    }
}

using week_3_assignment.Data.Models;

namespace week_3_assignment.Data.Repositories
{
 
       public class ProductFeatureRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
    {
        public ProductFeatureRepository(AppDbContext context) : base(context)
        {
        }
    }
}

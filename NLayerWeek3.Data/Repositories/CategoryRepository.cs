using NLayerWeek3.Data.Models;

namespace NLayerWeek3.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

    }
}

using week_3_assignment.Data.Models;
using week_3_assignment.Data.Repositories;
using week_3_assignment.Data.UnitOfWork;

namespace week_3_assignment.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _context;

        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        private ProductFeatureRepository _productFeatureRepository;


        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public IProductFeatureRepository ProductFeatures => _productFeatureRepository = _productFeatureRepository ?? new ProductFeatureRepository(_context);



        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        
        }


 

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }






    }
}

using Microsoft.EntityFrameworkCore;
using week_3_assignment.Data.Models;


namespace week_3_assignment.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //getting database object
        protected readonly AppDbContext _context;

        //setting for a entity
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {

            await _dbSet.AddAsync(entity);


        }




        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Delete(T entity)
        {

            _dbSet.Remove(entity);
        }


        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }


    }
}

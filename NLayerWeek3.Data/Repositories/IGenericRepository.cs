using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerWeek3.Data.Repositories
{

    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();

        Task AddAsync(T entity);
    
        void Update(T entity);
        void Delete(T entity);
   

    }
}

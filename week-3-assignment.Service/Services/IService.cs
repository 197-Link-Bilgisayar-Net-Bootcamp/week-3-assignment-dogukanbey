using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_assignment.Service.Services
{
    public interface IService<T> where T : class
    {

        Task<T> AddAsync(T entity);


        Task<IEnumerable<T>> GetAllAsync();

       Task<T> GetByIdAsync(int id);

       Task RemoveAsync(T entity);

       Task UpdateAsync(T entity);





    }
}

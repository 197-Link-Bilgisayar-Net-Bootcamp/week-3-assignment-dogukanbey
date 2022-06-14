using week_3_assignment.Data.Models;
using week_3_assignment.Data.Repositories;

namespace week_3_assignment.Data.UOW
{
    public interface IUnitOfWork    
    {

        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task CommitAsync();
        void Commit();
     
    }
}

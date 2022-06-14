using AutoMapper;
using week_3_assignment.Data.Models;
using week_3_assignment.Data.Repositories;
using week_3_assignment.Data.UnitOfWork;
using week_3_assignment.Service.Services;

namespace week_3_assignment.Services.Services
{
    public class   CategoryService : Service<Category>, ICategoryService
    {
         

        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        
          
        }



    }
}

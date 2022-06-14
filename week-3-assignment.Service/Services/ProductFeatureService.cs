using week_3_assignment.Data.Models;
using week_3_assignment.Data.Repositories;
using week_3_assignment.Data.UnitOfWork;
using week_3_assignment.Service.Services;
using week_3_assignment.Services.Services;

namespace week_3_assignment.Services.Services
{
    public class ProductFeatureService : Service<ProductFeature> , IProductFeatureService
    {

        public ProductFeatureService(IGenericRepository<ProductFeature> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
         
          
        }
  

    }
}


 
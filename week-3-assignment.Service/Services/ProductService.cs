using AutoMapper;
using week_3_assignment.Data.Models;
using week_3_assignment.Data.Repositories;
using week_3_assignment.Data.UOW;
using week_3_assignment.Service.Services;

namespace week_3_assignment.Services.Services
{
    public class ProductService : Service<Product>, IProductService
    {
       
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

            
        }


    }
}
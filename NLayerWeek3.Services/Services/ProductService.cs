using AutoMapper;
using NLayerWeek3.Data.Models;
using NLayerWeek3.Data.Repositories;
using NLayerWeek3.Data.UOW;

namespace NLayerWeek3.Services.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
   
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, 
            IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            
        }


 


    }
}
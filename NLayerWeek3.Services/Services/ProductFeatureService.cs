using AutoMapper;
using NLayerWeek3.Data.Models;
using NLayerWeek3.Data.Repositories;
using NLayerWeek3.Data.UOW;

namespace NLayerWeek3.Services.Services
{
    public class ProductFeatureService : Service<ProductFeature>, IProductFeatureService
    {

        private readonly IProductFeatureRepository _productFeatureRepository;
        private readonly IMapper _mapper;


        public ProductFeatureService(IGenericRepository<ProductFeature> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductFeatureRepository productFeatureRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productFeatureRepository = productFeatureRepository;
        }




    }
}

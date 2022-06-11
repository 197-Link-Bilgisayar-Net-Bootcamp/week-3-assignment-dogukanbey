using AutoMapper;
using NLayerWeek3.Data.Models;
using NLayerWeek3.Data.Repositories;
using NLayerWeek3.Data.UOW;

namespace NLayerWeek3.Services.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;


        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }



    }
}

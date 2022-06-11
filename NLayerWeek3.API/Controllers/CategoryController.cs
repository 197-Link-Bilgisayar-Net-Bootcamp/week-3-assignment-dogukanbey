using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerWeek3.Data.Models;
using NLayerWeek3.Services.Dtos;
using NLayerWeek3.Services.Services;

namespace NLayerWeek3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _service;

        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {

            _mapper = mapper;
            _service = categoryService;
        }

 
 

        /// GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var categories = await _service.GetAllAsync();
            var categoriesDtos = _mapper.Map<List<CategoryDto>>(categories.ToList());
            return Ok(categoriesDtos);
        }




        // GET /api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {


            var category = await _service.GetByIdAsync(id);
            var categoryDtos = _mapper.Map<CategoryDto>(category);
            return Ok(categoryDtos);
        }




        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            await _service.UpdateAsync(_mapper.Map<Category>(categoryDto));

            return Ok(categoryDto);
        }



        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
            var category = await _service.AddAsync(_mapper.Map<Category>(categoryDto));
            var categoriesDtos = _mapper.Map<CategoryDto>(category);
            return Ok(categoriesDtos);
        }





        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(category);

            return Ok();
        }

    }
}

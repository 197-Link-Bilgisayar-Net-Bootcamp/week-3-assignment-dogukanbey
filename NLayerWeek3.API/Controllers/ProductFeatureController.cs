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
    public class ProductFeatureController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IProductFeatureService _service;
        public ProductFeatureController(IMapper mapper, IProductFeatureService productFeatureService)
        {

            _mapper = mapper;
            _service = productFeatureService;
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


            var productFeature = await _service.GetByIdAsync(id);
            var productFeatureDtos = _mapper.Map<ProductFeatureDto>(productFeature);
            return Ok(productFeatureDtos);
        }




        [HttpPut]
        public async Task<IActionResult> Update(ProductFeatureDto productFeatureDto)
        {
            await _service.UpdateAsync(_mapper.Map<ProductFeature>(productFeatureDto));

            return Ok(productFeatureDto);
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductFeatureDto productFeatureDto)
        {
            var productFeature = await _service.AddAsync(_mapper.Map<ProductFeature>(productFeatureDto));
            var productFeaturesDto = _mapper.Map<ProductFeatureDto>(productFeature);
            return Ok(productFeaturesDto);
        }





        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var productFeature = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(productFeature);

            return Ok();
        }

    }
}

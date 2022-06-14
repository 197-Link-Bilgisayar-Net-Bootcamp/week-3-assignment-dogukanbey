using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week_3_assignment.Data.Models;
using week_3_assignment.Data.UnitOfWork;
using AutoMapper;
using week_3_assignment.Service.Services.Dtos;
using week_3_assignment.Service.Services;


namespace week_3_assignment.API.Controllers
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


        // GET /api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var productFeature = await _service.GetByIdAsync(id);
            var productFeatureDto = _mapper.Map<ProductFeatureDto>(productFeature);
            return Ok(productFeatureDto);
        }



        [HttpPost]
        public async Task<IActionResult> Add(ProductFeatureDto productFeature)
        {



            var productFeatures = await _service.AddAsync(_mapper.Map<ProductFeature>(productFeature));
            var productFeaturesDto = _mapper.Map<ProductFeatureDto>(productFeatures);


            return Ok();

        }



        [HttpPut]
        public async Task<IActionResult> Update(ProductFeatureDto productFeaturesDto)
        {

            await _service.UpdateAsync(_mapper.Map<ProductFeature>(productFeaturesDto));


            return Ok();
        }






        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var productFeatures = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(productFeatures);


            return Ok();
        }

    }
}
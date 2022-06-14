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
    public class ProductController : ControllerBase
    {

        
        private readonly IMapper _mapper;
 
        private readonly IProductService _service;
        public ProductController(IMapper mapper, IProductService productService)
        {

            _mapper = mapper;
            _service = productService;
        }







        /// GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
    
            return Ok(await _service.GetAllAsync()); 
        }


 

        // GET /api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var product = await _service.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }


        [HttpPost]
        public async Task<IActionResult> Add(ProductDto productDto)
        {
         


            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDto = _mapper.Map<ProductDto>(product);
 

            return Ok();    

        }
        


        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {

            await _service.UpdateAsync(_mapper.Map<Product>(productDto));


            return Ok();
        }






        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(product);


            return Ok();
        }



 
    
    
    }
}

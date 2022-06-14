﻿using Microsoft.AspNetCore.Http;
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

            return Ok(await _service.GetAllAsync());
        }




        // GET /api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var category = await _service.GetByIdAsync(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return Ok(categoryDto);
        }


        [HttpPost]
        public async Task<IActionResult> Add(CategoryDto categoryDto)
        {



            var category = await _service.AddAsync(_mapper.Map<Category>(categoryDto));
            var productsDto = _mapper.Map<CategoryDto>(category);


            return Ok();

        }



        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {

            await _service.UpdateAsync(_mapper.Map<Category>(categoryDto));


            return Ok();
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

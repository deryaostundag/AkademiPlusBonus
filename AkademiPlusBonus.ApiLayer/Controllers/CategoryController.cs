﻿using AkademiPlusBonus.BusinessLayer.Abstract;
using AkademiPlusBonus.DtoLayer.CategoryDto;
using AkademiPlusBonus.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusBonus.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values=_categoryService.TGetList();
            return Ok(values);
        }
        [HttpGet("CategoryListWithDTO")]
        public IActionResult CategoryListWithDTO()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return Ok();
        }
        [HttpPost("AddCategoryWithDTO")]
        public IActionResult AddCategoryWithDTO(CreateCategoryDto createCategoryDto) 
        {
            Category category = new Category()
            {
                CategoryName= createCategoryDto.CategoryName,
            };

            _categoryService.TInsert(category);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value=_categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value=_categoryService.TGetByID(id);
            return Ok(value);
        }
    }
}

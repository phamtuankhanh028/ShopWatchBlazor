using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWatch.Server.Services.CategoryService;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Controllers
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
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories()); //Các category được gọi từ Service
        }



        [HttpPost("admin/category/add")]
        public async Task<ActionResult<bool>> AddCategory([FromBody] Category category)
        {
            
            var result = await _categoryService.AddCategory(category);
            return Ok(result);
        }

        [HttpPut("admin/category/update")]
        public async Task<ActionResult<bool>> UpdateCategory([FromBody] Category category)
        {

            var result = await _categoryService.UpdateCategory(category);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<bool>> GetCategoryById(int id)
        {

            var result = await _categoryService.GetCategoryById(id);
            return Ok(result);
        }
        [HttpDelete("admin/{id}")]
        public async Task<ActionResult<bool>> DeleteCategory(int id)
        {
            var result = await _categoryService.DeleteCategory(id);
            return Ok(result);
        }
    }
}

using EfCoreExample.Data;
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using EFCoreExample.Services;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        //appdbcontext is used to interact with our db
        //constructor is used by our dependency manager to inject it into our class
        //we don't have to instantiate the controller or provide the app db context into the constructor
       private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }
        [HttpGet("{CategoryId}")]
        public ActionResult<CategoryDTO> GetCategoryById(int CategoryId)
        {
           var category = _categoryService.GetCategoryById(CategoryId);
            return category;
        }

        [HttpPost]
        public ActionResult<CategoryDTO> PostCategory(CategoryDTO categoryDTO)
        {
            var category = _categoryService.CreateCategory(categoryDTO);

            return CreatedAtAction(nameof(GetCategoryById), new { CategoryId = category.CategoryId }, categoryDTO);
        }

        [HttpPut("{CategoryId}")]
        public ActionResult<CategoryDTO> UpdateCategory(int CategoryId, CategoryDTO UpdatedCategory)
        {
            _categoryService.UpdateCategory(CategoryId, UpdatedCategory);

            return Ok(UpdatedCategory);
        }

        [HttpDelete("{CategoryId}")]
         public IActionResult DeleteProduct(int CategoryId)
         {
            _categoryService.DeleteCategory(CategoryId);

            return Ok();
         }
    }
}
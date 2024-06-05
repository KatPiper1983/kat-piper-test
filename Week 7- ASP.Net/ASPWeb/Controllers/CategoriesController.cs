using EfCoreExample.Data;
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        //appdbcontext is used to interact with our db
        //constructor is used by our dependency manager to inject it into our class
        //we don't have to instantiate the controller or provide the app db context into the constructor
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categories = _context.Categories
                            .Select(c => new CategoryDTO
                            {
                                Name = c.Name,
                                
                                
                            }).ToList();
                        return categories;
        }
        [HttpGet("{CategoryId}")]
        public ActionResult<CategoryDTO> GetCategoryById(int CategoryId)
        {
            var category = _context.Categories.Find(CategoryId);
            var categoryDTO = new CategoryDTO
            {
                Name = category.Name,
                

            };
            return categoryDTO;
        }

        [HttpPost]
        public ActionResult<CategoryDTO> PostCategory(CategoryDTO categoryDTO)
        {
            var category = new Category
            {
                Name = categoryDTO.Name,
               
                
            };
            _context.Categories.Add(category);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCategoryById), new { CategoryId = category.CategoryId }, categoryDTO);
        }

        [HttpPut("{CategoryId}")]
        public ActionResult<CategoryDTO> UpdateCategory(int CategoryId, CategoryDTO UpdatedCategory)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
            category.Name = UpdatedCategory.Name;

            _context.Categories.Update(category);
            _context.SaveChanges();

            return Ok(UpdatedCategory);
        }

        [HttpDelete("{ProductId}")]
         public IActionResult DeleteProduct(int ProductId)
         {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
         }
    }
}
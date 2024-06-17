using EfCoreExample.Data;
using EFCoreExample.Controllers;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;

namespace EFCoreExample.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public Category CreateCategory(CategoryDTO categoryDTO)
        {
             var category = new Category
            {
                Name = categoryDTO.Name,
                Products = new List<Product>()               
                
            };
            _context.Categories.Add(category);
            _context.SaveChanges();

            return category;
        }

        public void DeleteCategory(int CategoryId)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            var categories = _context.Categories
                            .Select(c => new CategoryDTO
                            {
                                Name = c.Name,
                                
                                
                            }).ToList();
            return categories;
        }

        public CategoryDTO GetCategoryById(int CategoryId)
        {
            var category = _context.Categories.Find(CategoryId);
            var categoryDTO = new CategoryDTO
            {
                Name = category.Name,                

            };
            return categoryDTO;
        }

        public void UpdateCategory(int CategoryId, CategoryDTO UpdatedCategory)
        {
             var category = _context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
            category.Name = UpdatedCategory.Name;

            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}
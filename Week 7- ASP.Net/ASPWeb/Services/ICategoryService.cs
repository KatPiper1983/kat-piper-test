using EFCoreExample.DTOs;
using EFCoreExample.Models;


namespace EFCoreExample.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetAllCategories();

        CategoryDTO GetCategoryById(int CategoryId);

        Category CreateCategory(CategoryDTO CategoryDto);

        void UpdateCategory(int CategoryId, CategoryDTO UpdatedCategory);
        void DeleteCategory(int CategoryId);
    }


}
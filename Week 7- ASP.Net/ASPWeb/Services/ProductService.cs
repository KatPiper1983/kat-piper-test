using EfCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;




namespace EFCoreExample.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public Product CreateProduct(ProductDTO productDTO)
        {
            // Want to grab category that product is based on
            // Because product entity contains the entity of category, need to include
            // all entities int our "to be created" entity
            // first need to grab category entity from database, since ProdcutDTO only has
            // category name, this is only way can filter through category entities
                       
            var category = _context.Categories.FirstOrDefault(c=>c.Name == productDTO.CategoryName);
            // Need to check to see if category name provided exists
            // if category is null, then category provided doesn't exist in DB and need to let know is bad request
           /* if(category == null)
            {
                //"Category" + product.DTO.CategoryName + "does not exist"
                //using $ in front of double quotes allows string interpolation
                
                return BadRequest($"Category{productDTO.CategoryName} does not exist");
            }*/
            // If category does exist, then can use both category entity and ProductDTO to create product entity
            var product = new Product
            {
                Name = productDTO.Name,
                Price = productDTO.Price,
                CategoryId = category.CategoryId,
                Category = category
                
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        

       

        private bool ValidateNewUser(UserDTO UserDto)
        {
            if(UserDto.Name.Trim().Length == 0)
            {
                return false;
            }
            else return true;
        }

        public void DeleteProduct(int ProductId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
           var products = _context.Products 
           // Need to include the foreign key relationships b/c EF will not load unless
           // specifically tell it to include it
                            .Include(p=>p.Category)
                            .Select(p => new ProductDTO
                            {
                                Name = p.Name,
                                Price = p.Price,
                                CategoryName = p.Category.Name
                                
                            }).ToList();
                    return products;
        }

        public ProductDTO GetProductById(int ProductId)
        {
            var product = _context.Products.Find(ProductId);
            var productDTO = new ProductDTO
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                

            };
            return productDTO;
        }

        public void UpdateProduct(int id, ProductDTO updatedProduct)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Name == updatedProduct.CategoryName);
           var product = _context.Products.Include(p => p.Category)
                                        .FirstOrDefault(p => p.ProductId == id);
            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.CategoryId = category.CategoryId;
            product.Category = category;

            _context.Products.Update(product);
            _context.SaveChanges();

           
        }

       
    }
}
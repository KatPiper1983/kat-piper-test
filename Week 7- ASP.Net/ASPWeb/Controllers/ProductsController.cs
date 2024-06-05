using EfCoreExample.Data;
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        //appdbcontext is used to interact with our db
        //constructor is used by our dependency manager to inject it into our class
        //we don't have to instantiate the controller or provide the app db context into the constructor
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = _context.Products
                            .Select(p => new ProductDTO
                            {
                                Name = p.Name,
                                Price = p.Price,
                                
                            }).ToList();
                        return products;
        }
        [HttpGet("{ProductId}")]
        public ActionResult<ProductDTO> GetProductById(int ProductId)
        {
            var product = _context.Products.Find(ProductId);
            var productDTO = new ProductDTO
            {
                Name = product.Name,
                Price = product.Price,

            };
            return productDTO;
        }

        [HttpPost]
        public ActionResult<ProductDTO> PostProduct(ProductDTO productDTO)
        {
            var category = _context.Categories.FirstOrDefault(c=>c.Name == productDTO.CategoryName);
            var product = new Product
            {
                Name = productDTO.Name,
                Price = productDTO.Price,
                CategoryId = category.CategoryId,
                Category = category
                
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProductById), new { ProductId = product.ProductId }, productDTO);
        }

        [HttpPut("{ProductId}")]
        public ActionResult<ProductDTO> UpdateProfile(int ProductId, ProductDTO UpdatedProduct)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
            product.Name = UpdatedProduct.Name;

            _context.Products.Update(product);
            _context.SaveChanges();

            return Ok(UpdatedProduct);
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
using EfCoreExample.Data;
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using EFCoreExample.Services;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        //appdbcontext is used to interact with our db
        //constructor is used by our dependency manager to inject it into our class
        //we don't have to instantiate the controller or provide the app db context into the constructor
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: /Products
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{ProductId}")]
        public ActionResult<ProductDTO> GetProductById(int ProductId)
        {
            var product = _productService.GetProductById(ProductId);
            return product;
        }
        // POST: /Products
        // Expect them to provide a JSON body that matches ProductDTO
        [HttpPost]
        public ActionResult<ProductDTO> PostProduct(ProductDTO productDTO)
        {
           var product = _productService.CreateProduct(productDTO);

            return CreatedAtAction(nameof(GetProductById), new { ProductId = product.ProductId }, productDTO);
        }
        // PUT: /Products/23
        [HttpPut("{id}")]
        public ActionResult<ProductDTO> UpdateProfile(int ProductId, ProductDTO UpdatedProduct)
        {
           _productService.UpdateProduct(ProductId, UpdatedProduct);

            return Ok(UpdatedProduct);
        }

        [HttpDelete("{ProductId}")]
         public IActionResult DeleteProduct(int ProductId)
         {
           _productService.DeleteProduct(ProductId);

            return Ok();
         }
    }
}
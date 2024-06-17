using EFCoreExample.DTOs;
using EFCoreExample.Models;


namespace EFCoreExample.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts();

        ProductDTO GetProductById(int ProductId);

        Product CreateProduct(ProductDTO ProductDto);

        void UpdateProduct(int ProductId, ProductDTO UpdatedProduct);
        void DeleteProduct(int ProductId);
    }


}
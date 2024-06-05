using System.Net.Http.Headers;

namespace EFCoreExample.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //establishes one to many relationship for category class
        //a category can be associated w/ many products
        //use ICollection<>  interface b/c EF manages this relationship for us
        public ICollection<Product> Products { get; set; }

    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set;}
        public Category Category { get; set; }

        
    }

}
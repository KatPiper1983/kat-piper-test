using EfCoreExample.Data;
using Microsoft.AspNetCore.Mvc;

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
    }
}
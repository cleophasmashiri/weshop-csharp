using Microsoft.AspNet.Mvc;
using weshop.DAL;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace weshop.Controllers
{
    public class ProductController : Controller
    {
        private ShoppingDbContext dbContext;

        public ProductController(ShoppingDbContext db)
        {
            dbContext = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(dbContext.Products);
        }
    }
}

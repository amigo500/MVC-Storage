using Microsoft.AspNetCore.Mvc;

namespace Storage.Views.Products
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

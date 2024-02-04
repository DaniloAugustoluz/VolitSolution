using Microsoft.AspNetCore.Mvc;

namespace VolitSolution.Controllers
{
    public class Produtos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

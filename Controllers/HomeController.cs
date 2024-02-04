using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VolitSolution.Models;

namespace VolitSolution.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.nome = "Danilo Augusto";
            model.email = "teste@gmail.com";

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
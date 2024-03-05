using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            //ViewBag.Nombre = "Yonier Sisas";
            //ViewBag.Edad = 38;
            //var Persona = new Persona()
            //{
            //    Nombre = "Yonier Pedro Pablo Tipado",

            //    Edad = 15

            //};
            return View(); //"Index","Yonier Pedro Sisas" // /*"Index", Persona*/
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
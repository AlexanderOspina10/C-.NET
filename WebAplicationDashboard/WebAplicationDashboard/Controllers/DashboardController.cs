using Microsoft.AspNetCore.Mvc;
using WebAplicationDashboard.Models;

namespace WebAplicationDashboard.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DataTorta()
        {
            SerieTorta serie = new SerieTorta();
            return Json(serie.GetDataDumy()); //Sino se coloca el return da erorr el metodo
        }

        public JsonResult DataBarras()
        {
            SerieBarra serie = new SerieBarra();
            return Json(serie.GetDataDumy()); //Sino se coloca el return da erorr el metodo
        }
    }
}

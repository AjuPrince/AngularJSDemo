using System.Web.Mvc;
using AngularJSDemo.Entities;

namespace AngularJSDemo.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCars()
        {
            CarEntity carEntity = new CarEntity();
            var model = carEntity.Cars();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
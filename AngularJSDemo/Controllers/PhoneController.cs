using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSDemo.Entities;

namespace AngularJSDemo.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetMobilePhones()
        {
            MobilePhoneEntity mobilePhoneEntity = new MobilePhoneEntity();
            var model = mobilePhoneEntity.MobilePhone;
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
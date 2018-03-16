using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJSDemo.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClickDemo()
        {
            return View();
        }

        public ActionResult TextBoxIsEmpty()
        {
            return View();
        }

        public ActionResult CookieDemo()
        {
            return View();
        }
    }
}
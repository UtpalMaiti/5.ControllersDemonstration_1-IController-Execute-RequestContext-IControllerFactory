using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemonstration_1.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ControllerName = "Admin";

            ViewBag.ActionName = RouteData.Values["action"];

            return View("TestView");
        }

        public ActionResult ApproveUsers()
        {
            ViewBag.ControllerName = RouteData.Values["controller"];

            ViewBag.ActionName = RouteData.Values["action"];

            return View("TestView");
        }
    }
}
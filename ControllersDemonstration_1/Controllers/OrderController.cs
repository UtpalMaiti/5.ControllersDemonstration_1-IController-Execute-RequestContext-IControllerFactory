using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemonstration_1.Controllers
{
    public abstract class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            ViewBag.ControllerName = RouteData.Values["controller"];

            ViewBag.ActionName = RouteData.Values["action"];

            return View("TestView");
        }

        public ActionResult CreateOrder()
        {
            ViewBag.ControllerName = RouteData.Values["controller"];

            ViewBag.ActionName = RouteData.Values["action"];

            return View("TestView");
        }
    }
}
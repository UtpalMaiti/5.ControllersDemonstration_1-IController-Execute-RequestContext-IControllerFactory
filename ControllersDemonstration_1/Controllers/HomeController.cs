using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersDemonstration_1.Controllers
{
    public class HomeController : AsyncController
    {
        //public class HomeController : Controller
        //{
        //public class HomeController : IController
        //{
        //public void Execute(RequestContext requestContext)
        //{
        //    var controllerName = requestContext.RouteData.Values["controller"];

        //    var actionName = requestContext.RouteData.Values["action"];

        //    requestContext.HttpContext.Response.Write("<h2>Welcome to the Concept of Controllers...</h2>");

        //    requestContext.HttpContext.Response.Write("<p>Controller Name is : <b>" + controllerName + "</b></p>");
        //    requestContext.HttpContext.Response.Write("<p>Action Name is : <b>" + actionName + "</b></p>");
        //}

        public async Task<ActionResult> Index()
        {
            SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS;database=EmployeeDB;integrated security=true");

            string query = "select count(*) from EMpInfo";

            SqlCommand cmd = new SqlCommand(query, conn);

            await conn.OpenAsync();

            int noOfEmployees = (int)await cmd.ExecuteScalarAsync();

            conn.Close();

            ViewBag.ControllerName = "Home";

            ViewBag.ActionName = RouteData.Values["action"].ToString() + "  " + noOfEmployees;

            return View("TestView");
        }

        public ActionResult Register()
        {
            ViewBag.ControllerName = RouteData.Values["controller"];

            ViewBag.ActionName = RouteData.Values["action"];

            return View("TestView");
        }
    }
}
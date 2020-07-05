using ControllersDemonstration_1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace ControllersDemonstration_1.UtilityClasses
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type t = null;

            switch (controllerName)
            {
                case "Home":
                    t = typeof(HomeController);
                    break;

                case "Admin":
                    t = typeof(AdminController);
                    break;

                case "Order":
                    t = typeof(AdminController);
                    break;
            }

            var obj = DependencyResolver.Current.GetService(t);

            //return (IController)obj;
            return obj as IController;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disp = controller as IDisposable;

            if (disp != null)
            {
                disp.Dispose();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebUI.Infrastructure;
using WebUI.Binders;
using Domain.Entities;

namespace WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
                "",  //Соответствует пустому URL                
                new { controller = "Product", action = "List", category = (string)null, page=1 }
            );
            routes.MapRoute(null,
                "Page{page}",   //Соответствует /Page1, /Page123
                new { controller = "Product", action = "List", category = (string)null },
                new { page=@"\d+"}
            );
            routes.MapRoute(null,
                "{category}",   //Соответствует /Football или /Soccer
                new { controller = "Product", action = "List", page = 1 }
            );
            routes.MapRoute(null,
                "{category}/Page{page}",    //Соответствует /Football/Page1     
                new { controller = "Product", action = "List" },
                new { page = @"\d+" }
            );
            routes.MapRoute(
                null,
                "{controller}/{action}"
            );
        }
    }
}

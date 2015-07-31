using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Scrawl
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Setup",
                url: "setup",
                defaults: new { controller = "Users", action = "UserSetup", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Scheduler",
                url: "scheduler",
                defaults: new { controller = "Users", action = "ScheduleSetup", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Users",
               url: "users",
               defaults: new { controller = "Users", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Create User",
               url: "users/create",
               defaults: new { controller = "Users", action = "Create", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Your Notebook",
               url: "notebook",
               defaults: new { controller = "Notebooks", action = "Notebook", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Notebooks",
               url: "notebooks",
               defaults: new { controller = "Notebooks", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Create Notebook",
               url: "notebooks/create",
               defaults: new { controller = "Notebooks", action = "Create", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Courses",
               url: "courses",
               defaults: new { controller = "Course", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Create Course",
               url: "courses/create",
               defaults: new { controller = "Course", action = "Create", id = UrlParameter.Optional }
           );
        }
    }
}

using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcFolders.StubApp.App.Home;

namespace MvcFolders.StubApp
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FeatureFolders.Register(typeof(HomeController).Assembly, "MvcFolders.StubApp.App");

            RouteTable.Routes.MapRoute(
                name: "Fallback",
                url: "Fallback/{action}/{id}",
                defaults: new { controller = "Fallback", action = "Index", id = UrlParameter.Optional });
        }
    }

    public class FallbackController : Controller
    {
        public ActionResult Index()
        {
            return Content("Fell through to the fallback controller");
        }
    }
}
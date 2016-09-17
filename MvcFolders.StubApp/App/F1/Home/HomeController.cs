using System.Web.Mvc;

namespace MvcFolders.StubApp.App.F1.Home
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("Response - F1/Home/Index");
        }

        public ActionResult Other()
        {
            return Content("Response - F1/Home/Other");
        }
    }
}
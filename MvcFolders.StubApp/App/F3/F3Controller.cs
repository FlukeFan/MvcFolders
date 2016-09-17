using System.Web.Mvc;

namespace MvcFolders.StubApp.App.F3
{
    public class F3Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Param1(int param1)
        {
            return Content("param1=" + param1);
        }
    }
}
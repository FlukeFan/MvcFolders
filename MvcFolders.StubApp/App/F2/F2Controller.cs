using System.Web.Mvc;

namespace MvcFolders.StubApp.App.F2
{
    public class F2Controller : Controller
    {
        public ActionResult Index()
        {
            return Content("Response - F2/Index");
        }

        [HttpGet]
        public ActionResult Form(int formId)
        {
            return View(formId);
        }

        [HttpPost]
        public ActionResult Form(string value)
        {
            return Redirect("posted=" + value);
        }

        [HttpGet]
        public ActionResult FormIllegal(int formId)
        {
            return null;
        }

        [HttpGet]
        public ActionResult FormIllegal(string formId)
        {
            return null;
        }
    }
}
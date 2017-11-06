using System.Web.Mvc;

namespace MvcFolders.StubApp.App.F1.F12.Forms
{
    public class FormsController : Controller
    {
        // form, post, custom object
        // form, post, parameters

        [HttpGet]
        public ActionResult Form(int formId)
        {
            return View(formId);
        }

        [HttpPost]
        public ActionResult Form(string formIdentifier)
        {
            return Redirect($"posted={formIdentifier}");
        }

        [HttpGet]
        public ActionResult FormModel(int formId)
        {
            return View(formId);
        }

        [HttpPost]
        public ActionResult FormModel(FormModel model)
        {
            return Redirect($"posted={model.ModelValue}");
        }

        [HttpGet]
        public ActionResult FormModelAndRouteParameter(int formId)
        {
            return View(formId);
        }

        [HttpPost]
        public ActionResult FormModelAndRouteParameter(int formId, FormModel model)
        {
            return Redirect($"formId={formId}&posted={model.ModelValue}");
        }

        [HttpGet]
        public ActionResult FormNoBinding(int formId)
        {
            return View(formId);
        }

        [HttpPost]
        public ActionResult FormNoBinding()
        {
            return Redirect($"no_binding_{Request.Form["ModelValue"]}");
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
using System;
using System.Web;
using MvcFolders.StubApp.App.Home;

namespace MvcFolders.StubApp
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FeatureFolders.Register(typeof(HomeController).Assembly, "MvcFolders.StubApp.App");
        }
    }
}
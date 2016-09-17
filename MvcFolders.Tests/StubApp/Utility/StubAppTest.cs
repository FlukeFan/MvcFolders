using MvcFolders.StubApp.App.Home;
using MvcTesting.Hosting;
using NUnit.Framework;

namespace MvcFolders.Tests.StubApp.Utility
{
    [TestFixture]
    public abstract class StubAppTest
    {
        protected static AspNetTestHost StubApp { get; private set; }

        public static void SetUpWebHost()
        {
            StubApp = AspNetTestHost.For(@"..\..\..\MvcFolders.StubApp", typeof(TestHostStartup));
        }

        public static void TearDownWebHost()
        {
            using (StubApp) { }
        }

        private class TestHostStartup : AppDomainProxy
        {
            public TestHostStartup()
            {
                HomeController.RootHomeControllerResponseText = "root home controller";
            }
        }
    }
}

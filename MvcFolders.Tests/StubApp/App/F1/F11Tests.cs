using FluentAssertions;
using MvcFolders.Tests.StubApp.Utility;
using NUnit.Framework;

namespace MvcFolders.Tests.StubApp.App.F1
{
    [TestFixture]
    public class F11Tests : StubAppTest
    {
        [Test]
        public void Index_GetByConvention()
        {
            StubApp.Test(http =>
            {
                var response = http.Get("/f1/f11");

                response.Text.Should().Contain("Response - F1/F11/Index");
            });
        }

        [Test]
        public void Index_GetExplicit()
        {
            StubApp.Test(http =>
            {
                var response = http.Get("/f1/f11/index");

                response.Text.Should().Contain("Response - F1/F11/Index");
            });
        }
    }
}

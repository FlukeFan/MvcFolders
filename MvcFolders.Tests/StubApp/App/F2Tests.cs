using System;
using System.Web.Mvc;
using FluentAssertions;
using MvcFolders.Tests.StubApp.Utility;
using NUnit.Framework;

namespace MvcFolders.Tests.StubApp.App
{
    [TestFixture]
    public class F2Tests : StubAppTest
    {
        [Test]
        public void Index_Get()
        {
            StubApp.Test(http =>
            {
                var response = http.Get("/f2");

                response.Text.Should().Contain("Response - F2/Index");
            });
        }

        [Test]
        public void Form_Post()
        {
            StubApp.Test(http =>
            {
                var view = http.Get("/f2/form/123");

                var response = view.Form<object>()
                    .Submit(http);

                response.ActionResultOf<RedirectResult>().Url.Should().Be("posted=123");
            });
        }

        [Test]
        public void FormIllegal()
        {
            StubApp.Test(http =>
            {
                Action act = () => http.Get("/f2/formIllegal/123");

                var e = act.ShouldThrow<Exception>("there are two methods registered which should throw a routing error");
            });
        }
    }
}

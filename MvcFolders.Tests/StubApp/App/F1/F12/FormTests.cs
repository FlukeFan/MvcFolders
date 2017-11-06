using System;
using System.Web.Mvc;
using FluentAssertions;
using MvcFolders.Tests.StubApp.Utility;
using NUnit.Framework;

namespace MvcFolders.Tests.StubApp.App.F1.F12
{
    [TestFixture]
    public class FormTests : StubAppTest
    {
        [Test]
        public void Form_Post()
        {
            StubApp.Test(http =>
            {
                var view = http.Get("/f1/f12/forms/form/123");

                var response = view.Form<object>()
                    .Submit(http);

                response.ActionResultOf<RedirectResult>().Url.Should().Be("posted=123");
            });
        }

        [Test]
        public void FormModel_Post()
        {
            StubApp.Test(http =>
            {
                var view = http.Get("/f1/f12/forms/formModel/123");

                var response = view.Form<object>()
                    .Submit(http);

                response.ActionResultOf<RedirectResult>().Url.Should().Be("posted=123");
            });
        }

        [Test]
        public void FormModelAndRouteParameter_Post()
        {
            StubApp.Test(http =>
            {
                var view = http.Get("/f1/f12/forms/formModelAndRouteParameter/123");

                var response = view.Form<object>()
                    .Submit(http);

                response.ActionResultOf<RedirectResult>().Url.Should().Be("formId=123&posted=test123");
            });
        }

        [Test]
        public void FormNoBinding_Post()
        {
            StubApp.Test(http =>
            {
                var view = http.Get("/f1/f12/forms/formNoBinding/123");

                var response = view.Form<object>()
                    .Submit(http);

                response.ActionResultOf<RedirectResult>().Url.Should().Be("no_binding_test123");
            });
        }

        [Test]
        public void FormIllegal()
        {
            StubApp.Test(http =>
            {
                Action act = () => http.Get("/f1/f12/forms/formIllegal/123");

                var e = act.ShouldThrow<Exception>("there are two methods registered which should throw a routing error");
            });
        }
    }
}

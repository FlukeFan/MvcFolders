using FluentAssertions;
using MvcFolders.Tests.StubApp.Utility;
using NUnit.Framework;

namespace MvcFolders.Tests.StubApp
{
    [TestFixture]
    public class FallbackTests : StubAppTest
    {
        [Test]
        public void FallbackIfNoFeatureFound()
        {
            StubApp.Test(http =>
            {
                var response = http.Get("/Fallback");

                response.Text.Should().Contain("Fell through to the fallback controller");
            });
        }
    }
}

﻿using MvcFolders.Tests.StubApp.Utility;
using NUnit.Framework;

namespace MvcFolders.Tests.StubApp
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [SetUp]
        public void SetUp()
        {
            try
            {
                StubAppTest.SetUpWebHost();
            }
            catch
            {
                StubAppTest.TearDownWebHost();
                throw;
            }
        }

        [TearDown]
        public void TearDown()
        {
            StubAppTest.TearDownWebHost();
        }
    }
}

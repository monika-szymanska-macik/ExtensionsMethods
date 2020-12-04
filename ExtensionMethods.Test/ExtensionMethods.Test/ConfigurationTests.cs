using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using ExtensionMethonds.Library;

namespace ExtensionMethods.Tests
{
    class ConfigurationTests
    {
        [Test]
        public void IsLoaded()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apex.ApexSharp.Implementation;
using NUnit.Framework;

namespace ApexParserTest.Apex
{
    [TestFixture]
    public class StubImplementationTests
    {
        [Test]
        public void StubImplementationHandlesPropertyGets()
        {
            dynamic date = new StubImplementation("Datetime");
            try
            {
                var y = date.Year;
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("get Datetime.Year", ex.Message);
            }
        }

        [Test]
        public void StubImplementationHandlesPropertySets()
        {
            dynamic date = new StubImplementation("Datetime");
            try
            {
                date.Epoch = 1970;
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("set Datetime.Epoch", ex.Message);
            }
        }

        [Test]
        public void StubImplementationHandlesStaticParameterlessMethods()
        {
            dynamic date = new StubImplementation("Datetime");
            try
            {
                date.someMethod();
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("Datetime.someMethod()", ex.Message);
            }
        }

        [Test]
        public void StubImplementationHandlesStaticMethodsWithParameters()
        {
            dynamic date = new StubImplementation("Datetime");
            try
            {
                date.valueOf("Hello, World!", true);
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("Datetime.valueOf(String, Boolean)", ex.Message);
            }
        }
    }
}

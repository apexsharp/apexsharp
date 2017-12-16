using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class ExceptionTests
    {
        [Test]
        public void ExceptionConstructorsAreExecuted()
        {
            Assert.DoesNotThrow(() =>
            {
                var exc = new Exception();
                Assert.NotNull(exc);
                Assert.AreEqual("Exception occured.", exc.getMessage());

                exc = new Exception("Custom message");
                Assert.NotNull(exc);
                Assert.AreEqual("Custom message", exc.getMessage());

                var newExc = new Exception("Another message", exc);
                Assert.NotNull(newExc);
                Assert.AreEqual("Another message", newExc.getMessage());
                Assert.AreEqual(exc, newExc.getCause());

                var lastExc = new Exception(newExc);
                Assert.NotNull(lastExc);
                Assert.AreEqual("Exception occured.", lastExc.getMessage());
                Assert.AreEqual(newExc, lastExc.getCause());
                Assert.AreEqual(exc, lastExc.getCause().getCause());
            });
        }

        [Test]
        public void ExceptionCloneAndGetTypeMethodsAreExecuted()
        {
            Assert.DoesNotThrow(() =>
            {
                var exc = new Exception("Cloneable exception");
                Assert.NotNull(exc);
                Assert.AreEqual("Cloneable exception", exc.getMessage());
                Assert.AreEqual("Exception", exc.getTypeName());

                var clone = exc.clone() as Exception;
                Assert.NotNull(clone);
                Assert.AreEqual(exc.getMessage(), clone.getMessage());
                Assert.AreEqual(exc.getTypeName(), clone.getTypeName());
            });
        }
    }
}

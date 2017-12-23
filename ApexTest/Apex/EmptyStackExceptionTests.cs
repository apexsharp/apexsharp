using System.Dynamic;
using Apex.Apex;
using Apex.ApexSharp.Implementation;
using Apex.System;
using NUnit.Framework;
using IDisposable = System.IDisposable;

namespace ApexTest.System
{
    [TestFixture]
    public class EmptyStackExceptionTests
    {
        [Test]
        public void EmptyStackExceptionConstructorsAreExecuted()
        {
            Assert.DoesNotThrow(() =>
            {
                var exc = new EmptyStackException();
                Assert.NotNull(exc);
                Assert.AreEqual("The stack is empty.", exc.getMessage());

                exc = new EmptyStackException("Custom message");
                Assert.NotNull(exc);
                Assert.AreEqual("Custom message", exc.getMessage());

                var newExc = new EmptyStackException("Another message", exc);
                Assert.NotNull(newExc);
                Assert.AreEqual("Another message", newExc.getMessage());
                Assert.AreEqual(exc, newExc.getCause());

                var lastExc = new EmptyStackException(newExc);
                Assert.NotNull(lastExc);
                Assert.AreEqual("The stack is empty.", lastExc.getMessage());
                Assert.AreEqual(newExc, lastExc.getCause());
                Assert.AreEqual(exc, lastExc.getCause().getCause());
            });
        }

        [Test]
        public void EmptyStackExceptionCloneAndGetTypeMethodsAreExecuted()
        {
            Assert.DoesNotThrow(() =>
            {
                var exc = new EmptyStackException("Cloneable exception");
                Assert.NotNull(exc);
                Assert.AreEqual("Cloneable exception", exc.getMessage());
                Assert.AreEqual("EmptyStackException", exc.getTypeName());

                var clone = exc.clone() as EmptyStackException;
                Assert.NotNull(clone);
                Assert.AreEqual(exc.getMessage(), clone.getMessage());
                Assert.AreEqual(exc.getTypeName(), clone.getTypeName());
            });
        }
    }
}

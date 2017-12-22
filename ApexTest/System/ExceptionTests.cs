using System.Dynamic;
using Apex.ApexSharp.Implementation;
using Apex.System;
using NUnit.Framework;
using IDisposable = System.IDisposable;

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
                // parameterless constructor
                var exc = new Exception();
                Assert.NotNull(exc);
                Assert.AreEqual("Exception is thrown.", exc.getMessage());

                // constructor with string parameter
                exc = new Exception("Custom message");
                Assert.NotNull(exc);
                Assert.AreEqual("Custom message", exc.getMessage());

                // constructor with string and Exception parameters
                var newExc = new Exception("Another message", exc);
                Assert.NotNull(newExc);
                Assert.AreEqual("Another message", newExc.getMessage());
                Assert.AreEqual(exc, newExc.getCause());

                // constructor with Exception parameter
                var lastExc = new Exception(newExc);
                Assert.NotNull(lastExc);
                Assert.AreEqual("Exception is thrown.", lastExc.getMessage());
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

        [Test]
        public void ExceptionImplementationCanBeReplacedByExpandoObjectInstance()
        {
            var customMessage = "Hello World!";

            // dummy implementation for the Exception class
            IDisposable UseDummyImplementation()
            {
                // implement the parameterless constructor
                dynamic x = new ExpandoObject();
                x.Constructor = new global::System.Func<Exception>(() =>
                {
                    // implement getMessage() instance method
                    dynamic self = new ExpandoObject();
                    self.getMessage = new global::System.Func<string>(() => customMessage);
                    return new Exception(self);
                });

                // set the new implementation
                Implementor.SetImplementation<Exception>(x);
                return new Disposable(() => Implementor.ResetToDefault<Exception>());
            }

            using (UseDummyImplementation())
            {
                // try out the dummy implementation
                Assert.DoesNotThrow(() =>
                {
                    var exc = new Exception();
                    Assert.NotNull(exc);
                    Assert.AreEqual(customMessage, exc.getMessage());
                });
            }
        }

        [Test]
        public void ExceptionHasRealMessageAndStackTrace()
        {
            try
            {
                Type.forName("System.ThisTypeDoesNotExist");
            }
            catch (TypeException ex)
            {
                Assert.False(string.IsNullOrWhiteSpace(ex.getMessage()));
                Assert.False(string.IsNullOrWhiteSpace(ex.getStackTraceString()));
            }
        }
    }
}

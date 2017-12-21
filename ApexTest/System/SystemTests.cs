using Apex.ConnectApi;
using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    using System = global::Apex.System.System;

    [TestFixture]
    public class SystemTests
    {
        [Test]
        public void AssertMethodsUseNUnitAssert()
        {
            Assert.DoesNotThrow(() =>
            {
                System.assert(true);
                System.assert(true, "true is false");
                System.assertEquals("Hello", "Hello");
                System.assertEquals(1, 1, "1 ≠ 1");
                System.assertNotEquals("Hello", "World");
                System.assertNotEquals(1, 2, "1 == 2");
            });

            Assert.Throws<AssertionException>(() => System.assert(false));
            Assert.Throws<AssertionException>(() => System.assert(false, "false is true"));
            Assert.Throws<AssertionException>(() => System.assertEquals("Hello", "World"));
            Assert.Throws<AssertionException>(() => System.assertEquals(1, 2, "1 ≠ 2"));
            Assert.Throws<AssertionException>(() => System.assertNotEquals("Hello", "Hello"));
            Assert.Throws<AssertionException>(() => System.assertNotEquals(1, 1, "1 == 1"));
        }

        [Test]
        public void DateAndTimeRelatedFunctions()
        {
            Assert.DoesNotThrow(() =>
            {
                var millis = System.currentTimeMillis();
                Assert.NotZero(millis);

                //var now = System.now();
                //var today = System.today();
            });
        }

        [Test]
        public void MiscellaneousFunctions()
        {
            Assert.DoesNotThrow(() =>
            {
                using (System.runAs(default(User)))
                {
                    var hashCode = System.hashCode(null);
                    Assert.Zero(hashCode);
                };

                using (System.runAs(default(SObject)))
                {
                    var equals = System.equals(1, 1);
                    Assert.True(equals);
                };

                using (System.runAs(default(Version)))
                {
                    var notEquals = System.equals("Hello", "World");
                    Assert.False(notEquals);
                }

                using (System.runAs(default(SObject), null))
                {
                    System.debug(null);
                }
            });
        }

        [Test]
        public void SystemDebugIsImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                System.debug(123);
                System.debug(LoggingLevel.INTERNAL, "LoggingLevel is ignored");
            });
        }
    }
}

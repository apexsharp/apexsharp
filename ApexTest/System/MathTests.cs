using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void MathStaticPropertiesAndMethods()
        {
            Assert.DoesNotThrow(() =>
            {
                var e = Math.E;
                var pi = Math.PI;
                Assert.AreNotEqual(e, pi);

                var rnd = Math.random();
                Assert.GreaterOrEqual(rnd, 0);
                Assert.LessOrEqual(rnd, 1);

                Assert.AreEqual(1, Math.abs(-1));
                Assert.AreEqual(10L, Math.abs(-10L));
                Assert.AreEqual(100m, Math.abs(-100m));
                Assert.AreEqual(1000d, Math.abs(-1000d));

                Assert.AreEqual(1, Math.abs(1));
                Assert.AreEqual(10L, Math.abs(10L));
                Assert.AreEqual(100m, Math.abs(100m));
                Assert.AreEqual(1000d, Math.abs(1000d));

                // TODO: add the rest of the Math methods
            });
        }
    }
}

using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class TimeTests
    {
        [Test]
        public void TimeStaticPropertiesAndMethods()
        {
            Assert.DoesNotThrow(() =>
            {
                var now = Datetime.now().time();
                var notNow = Time.newInstance((now.hour() + 1) % 24,
                    (now.minute() + 5) % 60, now.second(), now.millisecond());
                Assert.AreNotEqual(now, notNow);

                var then = Time.newInstance(12, 11, 10, 9);
                Assert.AreEqual(12, then.hour());
                Assert.AreEqual(11, then.minute());
                Assert.AreEqual(10, then.second());
                Assert.AreEqual(9, then.millisecond());
            });
        }

        [Test]
        public void TimeInstancePropertiesAndMethods()
        {
            Assert.DoesNotThrow(() =>
            {
                var now = Datetime.now().time();
                var prevHours = now.addHours(-3);
                Assert.AreNotEqual(now, prevHours);

                var nextMinutes = now.addMinutes(15);
                Assert.AreNotEqual(now, nextMinutes);

                var prevSeconds = now.addSeconds(-30);
                Assert.AreNotEqual(now, prevSeconds);

                var nextMillis = now.addMilliseconds(534);
                Assert.AreNotEqual(now, nextMillis);
            });
        }
    }
}

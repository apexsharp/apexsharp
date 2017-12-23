using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class DateTests
    {
        [Test]
        public void DateStaticPropertiesAndMethods()
        {
            Assert.DoesNotThrow(() =>
            {
                var today = Date.today();
                var notToday = Date.newInstance(today.year() + 1, (today.month() + 1) % 12, (today.day() + 1) % 28);

                var then = Date.newInstance(1970, 12, 11);
                Assert.AreEqual(1970, then.year());
                Assert.AreEqual(12, then.month());
                Assert.AreEqual(11, then.day());

                var parsed = Date.parse("1970/12/11");
                Assert.AreEqual(1970, parsed.year());
                Assert.AreEqual(12, parsed.month());
                Assert.AreEqual(11, parsed.day());
            });
        }

        [Test]
        public void DatetimeInstancePropertiesAndMethods()
        {
            Assert.DoesNotThrow(() =>
            {
                var today = Date.today();
                var tomorrow = today.addDays(1);
                Assert.AreNotEqual(today, tomorrow);
                Assert.False(today.isSameDay(tomorrow));

                var prevMonth = today.addMonths(-1);
                Assert.AreNotEqual(today, prevMonth);

                var nextYears = today.addYears(10);
                Assert.AreNotEqual(today, nextYears);

                var today2 = Datetime.newInstance(today, Datetime.now().time()).date();
                Assert.AreEqual(today, today2);

                var hash1 = today.hashCode();
                var hash2 = today2.hashCode();
                Assert.AreEqual(hash1, hash2);
                Assert.NotNull(today.toString());
            });
        }
    }
}

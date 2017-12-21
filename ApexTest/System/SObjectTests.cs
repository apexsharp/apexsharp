using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class SObjectTests
    {
        public class UserLicense : SObject
        {
            public string LicenseDefinitionKey { set; get; }
            public int TotalLicenses { set; get; }
            public string Status { set; get; }
            public int UsedLicenses { set; get; }
            public string Name { set; get; }
            public string MasterLabel { set; get; }
            public Datetime CreatedDate { set; get; }
            public Datetime LastModifiedDate { set; get; }
            public Datetime SystemModstamp { set; get; }
        }

        public UserLicense License => new UserLicense
        {
            LicenseDefinitionKey = "Hello",
            TotalLicenses = 123,
            Status = "Trial",
            UsedLicenses = 100,
            Name = "ApexSharp",
            MasterLabel = "Master",
            CreatedDate = Datetime.now().addDays(-5),
            LastModifiedDate = Datetime.now(),
        };

        [Test]
        public void GetAndPutMethodsAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var ul = License;
                var value = ul.get(nameof(UserLicense.LicenseDefinitionKey));
                Assert.AreEqual("Hello", value);

                ul.put(nameof(UserLicense.LicenseDefinitionKey), "World");
                Assert.AreEqual("World", ul.LicenseDefinitionKey);
            });
        }

        [Test]
        public void GetPopulatedFieldsAsMapIsImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var ul = License;
                var now = Datetime.now().addMinutes(2);
                ul.LastModifiedDate = now;

                var map = ul.getPopulatedFieldsAsMap();
                Assert.AreEqual(8, map.size());

                Assert.AreEqual("Hello", map.get(nameof(UserLicense.LicenseDefinitionKey)));
                Assert.AreEqual(123, map.get(nameof(UserLicense.TotalLicenses)));
                Assert.AreEqual("Trial", map.get(nameof(UserLicense.Status)));
                Assert.AreEqual(100, map.get(nameof(UserLicense.UsedLicenses)));
                Assert.AreEqual("ApexSharp", map.get(nameof(UserLicense.Name)));
                Assert.AreEqual(now, map.get(nameof(UserLicense.LastModifiedDate)));
            });
        }
    }
}

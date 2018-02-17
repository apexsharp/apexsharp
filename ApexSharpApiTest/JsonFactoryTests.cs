using ApexSharpApi;
using ApexSharpApi.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApexSharpApiTest
{
    [TestFixture]
    public class JsonFactoryTests : TestBase
    {
        public class SampleSObject
        {
            public string Name { get; set; }
            [IgnoreUpdate]
            public DateTime IgnoredDate { get; set; }
            public int NotIgnoredInteger { get; set; }
            [IgnoreUpdate]
            public string IgnoredString { get; set; }
        }

        [Test]
        public void JsonFactoryGetIgnoredPropertiesDoesntThrowANullReferenceException()
        {
            var propList = JsonFactory.GetIgnoredProperties(null);
            Assert.NotNull(propList);
            Assert.IsEmpty(propList);
        }

        [Test]
        public void JsonFactoryGetIgnoredPropertiesReturnsListOfIgnoredProperties()
        {
            var propList = JsonFactory.GetIgnoredProperties(new SampleSObject());
            var ignoreList = string.Join(", ", propList.OrderBy(p => p));
            Assert.AreEqual("IgnoredDate, IgnoredString", ignoreList);
        }
    }
}

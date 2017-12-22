using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class TypeTests
    {
        [Test]
        public void MscorlibSystemAndApexTypesAreDiscoverable()
        {
            Assert.DoesNotThrow(() =>
            {
                var type = Type.forName("System.String");
                Assert.NotNull(type);
                Assert.AreEqual("System.String", type.toString());

                Type.forName("SYSTEM.string");
                Assert.NotNull(type);
                Assert.AreEqual("System.String", type.toString());

                type = Type.forName("Apex.System.Datetime");
                Assert.NotNull(type);
                Assert.AreEqual("Apex.System.Datetime", type.toString());

                type = Type.forName("APEX.system.DateTime");
                Assert.NotNull(type);
                Assert.AreEqual("Apex.System.Datetime", type.toString());
            });
        }

        [Test]
        public void ApexTypeAndSystemTypeAreCompatible()
        {
            Assert.DoesNotThrow(() =>
            {
                Type type1 = typeof(string);
                Type type2 = Type.forName("system.string");

                Assert.AreEqual(type1, type2);
                Assert.AreEqual(type1.toString(), type2.toString());
                Assert.AreEqual(type1.hashCode(), type2.hashCode());
            });
        }

        public class SampleType
        {
            public string Message => "This is a sample type!";
        }

        [Test]
        public void NewInstanceMethodIsSupported()
        {
            Assert.DoesNotThrow(() =>
            {
                Type myType = typeof(SampleType);
                var instance = (SampleType)myType.newInstance();
                var otherInstance = new SampleType();

                Assert.AreNotSame(instance, otherInstance);
                Assert.AreEqual(instance.Message, otherInstance.Message);

                Type intType = typeof(int);
                var intInstance = (int)intType.newInstance();
                Assert.AreEqual(0, intInstance);

                // string doesn't have the default constructor
                Type stringType = typeof(string);
                Assert.Throws<TypeException>(() => stringType.newInstance());
            });
        }
    }
}

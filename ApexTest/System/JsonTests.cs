using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class JsonTests
    {
        public class MySampleClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        [Test]
        public void JsonCanSerializeAndDeserializeObjectsWithDefaultFormatting()
        {
            Assert.DoesNotThrow(() =>
            {
                var obj = new MySampleClass { Name = "Mickey", Age = 89 };
                var json = JSON.serialize(obj);
                Assert.False(string.IsNullOrWhiteSpace(json));
                Assert.AreEqual("{\"Name\":\"Mickey\",\"Age\":89}", json);

                var inst = (MySampleClass)JSON.deserialize(json, typeof(MySampleClass));
                Assert.NotNull(inst);
                Assert.AreEqual(obj.Name, inst.Name);
                Assert.AreEqual(obj.Age, inst.Age);
            });
        }

        [Test]
        public void JsonCanSerializeAndDeserializeObjectsWithIndentedFormatting()
        {
            Assert.DoesNotThrow(() =>
            {
                var obj = new MySampleClass { Name = "Goofy", Age = 85 };
                var json = JSON.serializePretty(obj);
                Assert.False(string.IsNullOrWhiteSpace(json));
                Assert.AreEqual("{\r\n  \"Name\": \"Goofy\",\r\n  \"Age\": 85\r\n}", json);

                var inst = (MySampleClass)JSON.deserialize(json, typeof(MySampleClass));
                Assert.NotNull(inst);
                Assert.AreEqual(obj.Name, inst.Name);
                Assert.AreEqual(obj.Age, inst.Age);
            });
        }

        [Test]
        public void JsonCanSerializeAndDeserializeObjectsWithSuppressedNulls()
        {
            Assert.DoesNotThrow(() =>
            {
                var obj = new MySampleClass();
                var json = JSON.serialize(obj, suppressApexObjectNulls: true);
                Assert.False(string.IsNullOrWhiteSpace(json));
                Assert.AreEqual("{\"Age\":0}", json);

                var inst = (MySampleClass)JSON.deserialize(json, typeof(MySampleClass));
                Assert.NotNull(inst);
                Assert.AreEqual(obj.Name, inst.Name);
                Assert.AreEqual(obj.Age, inst.Age);
            });
        }

        [Test]
        public void JsonCanSerializeAndDeserializeObjectsWithSuppressedNullsWithNiceFormatting()
        {
            Assert.DoesNotThrow(() =>
            {
                var obj = new MySampleClass();
                var json = JSON.serializePretty(obj, suppressApexObjectNulls: true);
                Assert.False(string.IsNullOrWhiteSpace(json));
                Assert.AreEqual("{\r\n  \"Age\": 0\r\n}", json);

                var inst = (MySampleClass)JSON.deserialize(json, typeof(MySampleClass));
                Assert.NotNull(inst);
                Assert.AreEqual(obj.Name, inst.Name);
                Assert.AreEqual(obj.Age, inst.Age);
            });
        }

        [Test]
        public void JsonHasConstructorAndCloneForSomeReason()
        {
            Assert.DoesNotThrow(() =>
            {
                var json = new JSON();
                var clone = json.clone();
                Assert.AreNotSame(json, clone);
            });
        }
    }
}

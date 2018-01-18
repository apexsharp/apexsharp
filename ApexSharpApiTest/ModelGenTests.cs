using System;
using System.Collections.Generic;
using System.Text;
using ApexSharpApi;
using ApexSharpApi.Model.RestApi;
using NUnit.Framework;
using static System.Math;

namespace ApexSharpApiTest
{
    [TestFixture]
    public class ModelGenTests
    {
        protected void CompareLineByLine(string actual, string expected)
        {
            var actualList = actual.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var expectedList = expected.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            for (int i = 0; i < Min(expectedList.Length, actualList.Length); i++)
            {
                Assert.AreEqual(expectedList[i].Trim(), actualList[i].Trim());
            }

            if (Abs(expectedList.Length - actualList.Length) > 1)
            {
                Assert.Fail("Too many difference in lines: expected {0}, actual {1}", expectedList.Length, actualList.Length);
            }
        }

        [Test]
        public void GetFieldTypeTranslatesFieldType()
        {
            var mg = new ModelGen();
            var field = new Field { type = "anytype", name = "test" };
            var type = mg.GetFieldType(field);
            Assert.AreEqual("object", type);

            field = new Field { type = "SomeUnknownType", name = "test" };
            type = mg.GetFieldType(field);
            Assert.AreEqual("NOT FOUND", type);
        }

        [Test]
        public void CreateSalesForceClassEmitsValidCSharpCode()
        {
            var detail = new SObjectDetail
            {
                name = "SampleClass",
                fields = new Field[]
                {
                    new Field
                    {
                        name = "OwnerId",
                        type = "reference",
                        referenceTo = new[] { "?", "AnotherSampleClass" },
                        relationshipName = "AnotherSampleInstance",
                    },
                },
            };

            var code = new ModelGen().CreateSalesForceClass("Test", detail);
            Assert.NotNull(code);

            CompareLineByLine(code, @"namespace Test
            {
	            using Apex.System;
	            using ApexSharpApi.ApexApi;

	            public class SampleClass : SObject
	            {
		            public string OwnerId {set;get;}
		            public AnotherSampleClass AnotherSampleInstance {set;get;}
	            }
            }");
        }
    }
}

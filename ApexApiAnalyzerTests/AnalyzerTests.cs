using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApexApiAnalyzer;
using NUnit.Framework;

namespace ApexApiAnalyzerTests
{
    [TestFixture]
    public class AnalyzerTests : TestBase
    {
        [Test]
        public void GetReferencedApiClassesForEmptyTreesReturnsEmptyDictionary()
        {
            var refs = new Analyzer().ProcessCSharpClasses();
            Assert.NotNull(refs);
            Assert.IsFalse(refs.Any());

            refs = new Analyzer().ProcessCSharpClasses("", null, "     ");
            Assert.NotNull(refs);
            Assert.IsFalse(refs.Any());
        }

        [Test]
        public void GetReferencedApiClassesForMapAndJsonReturnsApexClassesAndTheirMethods()
        {
            var refs = new Analyzer().ProcessCSharpClasses(@"using Apex.System;
            namespace ApexTest
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        var map = new Map<int, string>();
                        map.put(1, ""Hello"");

                        var json = JSON.serializePretty(map);
                        var length = json.Length;

                        var ignored = ""JSON.deserialize(json)"";
                        // ignored: map.get(1);
                    }
                }
            }");

            Assert.NotNull(refs);
            Assert.AreEqual(2, refs.Count);

            var classRef = default(ClassReference);
            Assert.IsTrue(refs.TryGetValue("apex.system.map", out classRef));
            Assert.NotNull(classRef);
            Assert.AreEqual(1, classRef.Methods.Count);

            var methodRef = default(MethodReference);
            Assert.IsTrue(classRef.Methods.TryGetValue("put(...)", out methodRef));

            Assert.IsTrue(refs.TryGetValue("apex.system.json", out classRef));
            Assert.NotNull(classRef);
            Assert.AreEqual(1, classRef.Methods.Count);
            Assert.IsTrue(classRef.Methods.TryGetValue("serializePretty(object)", out methodRef));
        }

        [Test]
        public void GetReferencedApiClassesForApexClassesReturnClassesAndMethods()
        {
            var refs = new Analyzer().ProcessApexClasses(@"// ClassRestTest
            @IsTest
            public class ClassRestTest
            {
                @IsTest
                public static void PostTest()
                {
                    RestContext.request = new RestRequest();
                    RestContext.response = new RestResponse();
                    ContactDTO contact = new ContactDTO();
                    contact.LastName = 'LastName';
                    RestContext.request.requestBody = Blob.valueOf(JSON.serialize(contact));
                    ClassRest.post();
                    System.assertEquals(200, RestContext.response.statusCode);
                    List<Contact> contacts = [SELECT Id FROM Contact WHERE LastName = 'LastName' LIMIT 1];
                    System.assertEquals(1, contacts.size());
                }
            }",
            @"// ClassUnitTest
            @IsTest
            public class ClassUnitTest
            {
                @TestSetup
                public static void setup()
                {
                    System.debug('Setup Got Called');
                }

                @IsTest
                public static void assert()
                {
                    System.assert(true, 'Assert True');
                }

                @IsTest
                public static void assertTestMethod()
                {
                    System.assert(true, 'Assert True');
                }

                @IsTest
                public static void assertEquals()
                {
                    System.assertEquals(5, 5, 'Assert Equal');
                }

                @IsTest
                public static void assertEqualsTestMethod()
                {
                    System.assertEquals(5, 5, 'Assert Equal');
                }

                @IsTest
                public static void assertNotEquals()
                {
                    System.assertNotEquals(5, 0, 'Assert Not Equal');
                }

                @IsTest
                public static void assertNotTestMethod()
                {
                    System.assertNotEquals(5, 0, 'Assert Not Equal');
                }
            }");

            Assert.NotNull(refs);
            Assert.AreEqual(7, refs.Count); // System, Blob, List, JSON, RestRequest, RestResponse, RestContext

            var classRef = default(ClassReference);
            Assert.True(refs.TryGetValue("Apex.System.System", out classRef));
            Assert.AreEqual(5, classRef.Methods.Count); // assert(), debug(), etc.
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Blob", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // valueOf()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.JSON", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // serialize()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.List", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // size()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.RestRequest", out classRef));
            Assert.AreEqual(0, classRef.Methods.Count); //
            Assert.AreEqual(1, classRef.Constructors.Count); // new RestRequest()
            Assert.AreEqual(1, classRef.Properties.Count); // requestBody

            Assert.True(refs.TryGetValue("Apex.System.RestResponse", out classRef));
            Assert.AreEqual(0, classRef.Methods.Count); //
            Assert.AreEqual(1, classRef.Constructors.Count); // new RestResponse()
            Assert.AreEqual(1, classRef.Properties.Count); // statusCode

            Assert.True(refs.TryGetValue("Apex.System.RestContext", out classRef));
            Assert.AreEqual(0, classRef.Methods.Count); //
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(2, classRef.Properties.Count); // request, response
        }

        [Test]
        public void GetReferencesFromZippedLibrary()
        {
            var files = GetApexClassesFromZipFile("apex-lambda-master").ToArray();
            var refs = new Analyzer().ProcessApexClasses(files);
            Assert.NotNull(refs);
            Assert.AreEqual(14, refs.Count);

            var classRef = default(ClassReference);
            Assert.True(refs.TryGetValue("Apex.System.System", out classRef));
            Assert.AreEqual(4, classRef.Methods.Count); // assert(), assertEquals(), etc.
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Datetime", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // newInstance()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Date", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // newInstance()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Time", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // newInstance()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Math", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // abs()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.List", out classRef));
            Assert.AreEqual(5, classRef.Methods.Count); // add(), clear(), iterator(), size(), etc.
            Assert.AreEqual(1, classRef.Constructors.Count); // new List()
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Set", out classRef));
            Assert.AreEqual(3, classRef.Methods.Count); // add(), contains(), size(), etc.
            Assert.AreEqual(1, classRef.Constructors.Count); // new Set(...)
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Map", out classRef));
            Assert.AreEqual(5, classRef.Methods.Count); // get(), put(), contains(), etc.
            Assert.AreEqual(1, classRef.Constructors.Count); // new Map()
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.ID", out classRef));
            Assert.AreEqual(0, classRef.Methods.Count); //
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.Type", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // newInstance()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.SObject", out classRef));
            Assert.AreEqual(5, classRef.Methods.Count); // getSObjectType(), get(), put(), etc.
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(1, classRef.Properties.Count); // Id

            Assert.True(refs.TryGetValue("Apex.System.NoSuchElementException", out classRef));
            Assert.AreEqual(0, classRef.Methods.Count); //
            Assert.AreEqual(1, classRef.Constructors.Count); // new NoSuchElementException()
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.Schema.SObjectType", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // newSObject()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //

            Assert.True(refs.TryGetValue("Apex.System.StringExtensions", out classRef));
            Assert.AreEqual(1, classRef.Methods.Count); // length()
            Assert.AreEqual(0, classRef.Constructors.Count); //
            Assert.AreEqual(0, classRef.Properties.Count); //
        }

        [Test]
        public void ProcessUrlDownloadsZipArchiveFromGithub()
        {
            var url = "https://github.com/ipavlic/apex-lambda";
            var refs = new Analyzer().ProcessUrl(url);
            Assert.NotNull(refs);
            Assert.True(refs.Any());
        }

        [Test]
        public void HasImplementationReturnsTrueIfAClassIsNotAStub()
        {
            var className = typeof(Apex.System.JSON).FullName;
            Assert.True(Analyzer.HasImplementation(className));

            className = typeof(Apex.WaveTemplate.ChecklistRemoter).FullName;
            Assert.False(Analyzer.HasImplementation(className));

            Assert.True(Analyzer.HasImplementation("Apex.System.Map"));
            Assert.True(Analyzer.HasImplementation("Apex.System.List"));
            Assert.True(Analyzer.HasImplementation("Apex.System.Set"));
            Assert.True(Analyzer.HasImplementation("Apex.System.ID"));
            Assert.False(Analyzer.HasImplementation("Apex.System.Idea"));
        }

        [Test]
        public void ApexWaveTemplateAnswersHasNoImplementation()
        {
            var refs = new Analyzer().ProcessCSharpClasses(@"using Apex.System;
            namespace ApexTest
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        var json = JSON.serializePretty(123);
                        var access = Apex.WaveTemplate.Access.integUserHasAccessToSObjectField(null, null);
                    }
                }
            }");

            Assert.NotNull(refs);
            Assert.AreEqual(2, refs.Count);

            var classRef = default(ClassReference);
            Assert.True(refs.TryGetValue("Apex.System.JSON", out classRef));
            Assert.True(classRef.HasImplementation);

            Assert.True(refs.TryGetValue("Apex.WaveTemplate.Access", out classRef));
            Assert.False(classRef.HasImplementation);
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using ApexSharpApi;
using ApexSharpApi.Model.RestApi;
using Newtonsoft.Json;
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

            // by default, the type is translated as string
            field = new Field { type = "SomeUnknownType", name = "test" };
            type = mg.GetFieldType(field);
            Assert.AreEqual("string", type);
        }

        private SObjectDetail SampleSObjectDetail
        {
            get => new SObjectDetail
            {
                name = "SampleClass",
                fields = new Field[]
                {
                    new Field
                    {
                        name = "OwnerId",
                        type = "reference",
                        referenceTo = new[] { "AnotherSampleClass" },
                        relationshipName = "AnotherSampleInstance",
                    },
                    new Field { name = "Name", type = "string", length = 255 },
                    new Field { name = "Age", type = "int" },
                    new Field
                    {
                        name = "OrgId",
                        type = "reference",
                        referenceTo = new[] { "SampleOrg" },
                        relationshipName = "Org",
                    },
                },
            };
        }

        [Test]
        public void CreateSalesForceClassEmitsValidCSharpCode()
        {
            var code = new ModelGen().CreateSalesForceClass("Test", SampleSObjectDetail);
            Assert.NotNull(code);

            CompareLineByLine(code, @"namespace Test
            {
                using Apex.System;
                using ApexSharpApi.ApexApi;
                using DateTime = global::System.DateTime;

                public class SampleClass : SObject
                {
                    public string OwnerId {set;get;}
                    public AnotherSampleClass AnotherSampleInstance {set;get;}
                    public string Name {set;get;}
                    public int Age {set;get;}
                    public string OrgId {set;get;}
                    public SampleOrg Org {set;get;}
                }
            }");
        }

        [Test]
        public void CreateSalesForceClassForSqliteEmitsValidCSharpCode()
        {
            var code = new ModelGen().CreateSalesForceClass("Test", SampleSObjectDetail, orm: true);
            Assert.NotNull(code);

            CompareLineByLine(code, @"namespace Test
            {
                using Apex.System;
                using ApexSharpApi.ApexApi;
                using ServiceStack.DataAnnotations;
                using DateTime = global::System.DateTime;

                public class SampleClass : SObject
                {
                    [StringLength(18)]
                    public string OwnerId {set;get;}
                    [Ignore]
                    public AnotherSampleClass AnotherSampleInstance {set;get;}
                    [StringLength(255)]
                    public string Name {set;get;}
                    public int Age {set;get;}
                    [StringLength(18)]
                    public string OrgId {set;get;}
                    [Ignore]
                    public SampleOrg Org {set;get;}
                }
            }");
        }

        [Test]
        public void GetReferencedSObjectsReturnsListOfReferencedObjects()
        {
            var refs = new ModelGen().GetReferencedSObjects(SampleSObjectDetail);
            Assert.AreEqual("AnotherSampleClass", refs[0]);
            Assert.AreEqual("SampleOrg", refs[1]);
        }

        private string GetJsonResource(string name)
        {
            var assembly = typeof(ModelGenTests).GetTypeInfo().Assembly;
            var rstream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.JsonSamples.{name}.json");
            using (var streamReader = new StreamReader(rstream))
            {
                return streamReader.ReadToEnd();
            }
        }

        [Test]
        public void GenerateCodeFromJsonResource()
        {
            var sobject = JsonConvert.DeserializeObject<SObjectDetail>(GetJsonResource("UserRole"));
            var code = new ModelGen().CreateSalesForceClass("TestNamespace", sobject, orm: false);
            Assert.NotNull(code);

            CompareLineByLine(code, @"namespace TestNamespace
            {
                using Apex.System;
                using ApexSharpApi.ApexApi;
                using DateTime = global::System.DateTime;

                public class UserRole : SObject
                {
                    public string Name {set;get;}
                    public string ParentRoleId {set;get;}
                    public string RollupDescription {set;get;}
                    public string OpportunityAccessForAccountOwner {set;get;}
                    public string CaseAccessForAccountOwner {set;get;}
                    public string ContactAccessForAccountOwner {set;get;}
                    public string ForecastUserId {set;get;}
                    public bool MayForecastManagerShare {set;get;}
                    public DateTime LastModifiedDate {set;get;}
                    public string LastModifiedById {set;get;}
                    public User LastModifiedBy {set;get;}
                    public DateTime SystemModstamp {set;get;}
                    public string DeveloperName {set;get;}
                    public string PortalAccountId {set;get;}
                    public string PortalType {set;get;}
                    public string PortalAccountOwnerId {set;get;}
                }
            }");
        }

        [Test]
        public void GenerateOrmSpecificCodeFromJsonResource()
        {
            var sobject = JsonConvert.DeserializeObject<SObjectDetail>(GetJsonResource("UserRole"));
            var code = new ModelGen().CreateSalesForceClass("TestNamespace", sobject, orm: true);
            Assert.NotNull(code);

            CompareLineByLine(code, @"namespace TestNamespace
            {
                using Apex.System;
                using ApexSharpApi.ApexApi;
                using ServiceStack.DataAnnotations;
                using DateTime = global::System.DateTime;

                public class UserRole : SObject
                {
                    [StringLength(80)]
                    public string Name {set;get;}
                    [StringLength(18)]
                    public string ParentRoleId {set;get;}
                    [StringLength(80)]
                    public string RollupDescription {set;get;}
                    [StringLength(40)]
                    public string OpportunityAccessForAccountOwner {set;get;}
                    [StringLength(40)]
                    public string CaseAccessForAccountOwner {set;get;}
                    [StringLength(40)]
                    public string ContactAccessForAccountOwner {set;get;}
                    [StringLength(18)]
                    public string ForecastUserId {set;get;}
                    public bool MayForecastManagerShare {set;get;}
                    public DateTime LastModifiedDate {set;get;}
                    [StringLength(18)]
                    public string LastModifiedById {set;get;}
                    [Ignore]
                    public User LastModifiedBy {set;get;}
                    public DateTime SystemModstamp {set;get;}
                    [StringLength(80)]
                    public string DeveloperName {set;get;}
                    [StringLength(18)]
                    public string PortalAccountId {set;get;}
                    [StringLength(40)]
                    public string PortalType {set;get;}
                    [StringLength(18)]
                    public string PortalAccountOwnerId {set;get;}
                }
            }");
        }

        [Test]
        public void GenerateCodeFromJsonResourceFiles()
        {
            // loads SObjectDetail from resources
            SObjectDetail loadSObject(string sobject) =>
                JsonConvert.DeserializeObject<SObjectDetail>(GetJsonResource(sobject));

            // saves the generated class locally
            var savedClasses = new ConcurrentDictionary<string, string>();
            void saveSObject(string fileName, string text) => savedClasses[fileName] = text;

            // unit test version of the model generator
            var mg = new ModelGen()
            {
                LoadSObject = loadSObject,
                SaveSObject = saveSObject
            };

            // Accounts references User, Contact, etc.
            var seed = new List<string> { "Account" };
            mg.CreateOfflineSymbolTable(seed, "TestNamespace");

            // Check that referenced classes are added recursively
            Assert.True(savedClasses.ContainsKey("Account"));
            Assert.True(savedClasses.ContainsKey("Contact"));
            Assert.True(savedClasses.ContainsKey("Profile"));
            Assert.True(savedClasses.ContainsKey("User"));
            Assert.True(savedClasses.ContainsKey("UserLicense"));
            Assert.True(savedClasses.ContainsKey("UserRole"));
        }
    }
}

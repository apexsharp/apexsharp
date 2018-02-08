using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApexApiAnalyzer;
using NUnit.Framework;

namespace ApexApiAnalyzerTests
{
    [TestFixture]
    public class SimpleReporterTests : TestBase
    {
        [Test]
        public void SampleReportIsGenerated()
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

                        RestContext.response = null;
                    }
                }
            }");

            CompareLineByLine(SimpleReporter.GetReport(refs.Values),
            @"Apex.System
                JSON
                    serializePretty(object)
                Map
                    new Map(...)
                    put(...)
                RestContext
                    response");
        }

        [Test]
        public void GetReferencesForListMapAndSetClasses()
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

                        var map2 = new Map<string, int>;
                        map.put(""World"", 123);

                        var list1 = new List<string>();
                        list1.add(""Hi"");

                        var list2 = new List<int>();
                        list2.add(123);

                        var set = new Set<int>();
                        var set2 = new Set<string>(list1);
                        var set3 = map2.keySet();
                        set3.add(""There"");
                    }
                }
            }");

            CompareLineByLine(SimpleReporter.GetReport(refs.Values),
              @"Apex.System
                  List
                    new List(...)
                    add(...)
                  Map
                    new Map(...)
                    keySet()
                    put(...)
                  Set
                    new Set(...)
                    add(...)");
        }

        [Test]
        public void GetReferenceReportFromZippedLibrary()
        {
            var files = GetApexClassesFromZipFile("apex-lambda-master").ToArray();
            var refs = new Analyzer().ProcessApexClasses(files);
            Assert.NotNull(refs);
            Assert.AreEqual(14, refs.Count);

            CompareLineByLine(SimpleReporter.GetReport(refs.Values),
              @"Apex.Schema
                  SObjectType
                    newSObject()
                Apex.System
                  Date
                    newInstance(int, int, int)
                  Datetime
                    newInstance(int, int, int)
                  ID
                  List
                    new List(...)
                    add(...)
                    addAll(...)
                    clear()
                    iterator()
                    size()
                  Map
                    new Map(...)
                    containsKey(...)
                    get(...)
                    keySet()
                    put(...)
                    size()
                  Math
                    abs(double)
                  NoSuchElementException
                    new NoSuchElementException()
                  Set
                    new Set(...)
                    add(...)
                    contains(...)
                    size()
                  SObject
                    get(Apex.Schema.SObjectField)
                    get(string)
                    getPopulatedFieldsAsMap()
                    getSObjectType()
                    put(string, object)
                    Id
                  StringExtensions
                    string.length()
                  System
                    assert(bool)
                    assert(bool, object)
                    assertEquals(object, object)
                    assertEquals(object, object, object)
                  Time
                    newInstance(int, int, int, int)
                  Type
                    newInstance()");
        }

        [Test]
        public void GetReferenceReportFromZipFile()
        {
            var refs = new Analyzer().ProcessZipFiles("ZipFiles/apex-lambda-master.zip");
            Assert.NotNull(refs);
            Assert.AreEqual(14, refs.Count);

            CompareLineByLine(SimpleReporter.GetReport(refs.Values),
              @"Apex.Schema
                  SObjectType
                    newSObject()
                Apex.System
                  Date
                    newInstance(int, int, int)
                  Datetime
                    newInstance(int, int, int)
                  ID
                  List
                    new List(...)
                    add(...)
                    addAll(...)
                    clear()
                    iterator()
                    size()
                  Map
                    new Map(...)
                    containsKey(...)
                    get(...)
                    keySet()
                    put(...)
                    size()
                  Math
                    abs(double)
                  NoSuchElementException
                    new NoSuchElementException()
                  Set
                    new Set(...)
                    add(...)
                    contains(...)
                    size()
                  SObject
                    get(Apex.Schema.SObjectField)
                    get(string)
                    getPopulatedFieldsAsMap()
                    getSObjectType()
                    put(string, object)
                    Id
                  StringExtensions
                    string.length()
                  System
                    assert(bool)
                    assert(bool, object)
                    assertEquals(object, object)
                    assertEquals(object, object, object)
                  Time
                    newInstance(int, int, int, int)
                  Type
                    newInstance()");
        }

        [Test]
        public void GetReportForDirectoryWithApexClasses()
        {
            var refs = new Analyzer().ProcessDirectories(".");
            Assert.NotNull(refs);
            Assert.AreEqual(18, refs.Count);

            CompareLineByLine(SimpleReporter.GetReport(refs.Values),
              @"Apex.System
                  ApexPages
                    addMessages(Apex.System.Exception)
                  Blob
                    toString()
                    valueOf(string)
                  Date
                    today()
                  Exception
                    getMessage()
                  JSON
                    deserialize(string, Apex.System.Type)
                    serialize(object)
                  List
                    new List(...)
                    add(...)
                    clear()
                    get(int)
                    isEmpty()
                    set(int, int)
                    size()
                    sort()
                  Map
                    new Map(...)
                    get(...)
                    keySet()
                    put(...)
                  Math
                    random()
                    round(double)
                  MathException
                    new MathException(string)
                  RestContext
                    request
                    response
                  RestRequest
                    new RestRequest()
                    requestBody
                  RestResponse
                    new RestResponse()
                    statusCode
                  SelectOption
                    new SelectOption(string, string)
                  Set
                    new Set(...)
                    add(...)
                    remove(int)
                  StringExtensions
                    string.length()
                  System
                    assert(bool)
                    assert(bool, object)
                    assertEquals(object, object)
                    assertEquals(object, object, object)
                    assertNotEquals(object, object, object)
                    debug(object)
                    runAs(Apex.System.Version)
                  Time
                    newInstance(int, int, int, int)");
        }

        [Test]
        public void GetNotImplementedReportForDirectoryWithApexClasses()
        {
            var refs = new Analyzer().ProcessDirectories(".");
            Assert.NotNull(refs);
            Assert.AreEqual(18, refs.Count);

            CompareLineByLine(SimpleReporter.GetReport(refs.Values, notImplementedOnly: true),
              @"Apex.System
                  ApexPages
                    addMessages(Apex.System.Exception)
                  SelectOption
                    new SelectOption(string, string)");
        }
    }
}

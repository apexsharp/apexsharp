namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [TestFixture]
    public class ClassUnitTest
    {
        [SetUp]
        public static void setup()
        {
            System.debug("Setup Got Called");
        }

        [Test]
        public static void assert()
        {
            System.assert(true, "Assert True");
        }

        [Test]
        public static void assertTestMethod()
        {
            System.assert(true, "Assert True");
        }

        [Test]
        public static void assertEquals()
        {
            System.assertEquals(5, 5, "Assert Equal");
        }

        [Test]
        public static void assertEqualsTestMethod()
        {
            System.assertEquals(5, 5, "Assert Equal");
        }

        [Test]
        public static void assertNotEquals()
        {
            System.assertNotEquals(5, 0, "Assert Not Equal");
        }

        [Test]
        public static void assertNotTestMethod()
        {
            System.assertNotEquals(5, 0, "Assert Not Equal");
        }
    }
}

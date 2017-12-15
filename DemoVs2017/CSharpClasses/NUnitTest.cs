using System;
namespace DemoVs2017.CSharpClasses
{
    using NUnit.Framework;

    [TestFixture]
    public class NUnitTest
    {
        [SetUp]
        public static void setup()
        {
            Console.WriteLine("Class Setup Called");
        }

        [Test]
        public static void assert()
        {
            Assert.AreEqual(1,1, "Assert True");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DemoVs2017.CSharpClasses
{

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

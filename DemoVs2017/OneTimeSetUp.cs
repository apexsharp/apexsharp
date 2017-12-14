using System;
using ApexSharpApi;
using NUnit.Framework;

namespace DemoVs2017
{
    [SetUpFixture]
    public class OneTimeSetUp
    {
        [OneTimeSetUp]
        public static void Init()
        {
           Console.WriteLine("One Time Setup Got Called");
           //UnitTestDataManager.UnitTestDataManagerOn();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
           //UnitTestDataManager.UnitTestDataManagerOff();
        }
    }
}

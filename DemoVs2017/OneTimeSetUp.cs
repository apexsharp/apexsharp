namespace DemoVs2017
{
    using System;
    using ApexSharpApi;
    using NUnit.Framework;

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

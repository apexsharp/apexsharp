namespace DemoVs2017.CSharpClasses
{
    using System;
    using NUnit.Framework;

    [SetUpFixture]
    public class OneTimeSetUp
    {
        [OneTimeSetUp]
        public void Init()
        {
           Console.WriteLine("One Time Setup Got Called");
           //UnitTestDataManager.UnitTestDataManagerOn();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            Console.WriteLine("One Time Cleanup Got Called");
            //UnitTestDataManager.UnitTestDataManagerOff();
        }
    }
}

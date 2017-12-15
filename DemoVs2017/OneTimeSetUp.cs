namespace DemoVs2017
{
    using NUnit.Framework;
    using System;

    [SetUpFixture]
    public class OneTimeSetUp
    {
        public OneTimeSetUp()
        {

        }

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

namespace ApexTest.System
{
    using global::Apex.ApexSharp.NUnit;
    using global::Apex.System;

    [TestFixture]
    public class ListTest
    {
        [Test]
        public static void addTest()
        {
            List<string> newList = new List<string>();
            newList.add("apexSharp");
            System.assert(newList.size() == 1);
        }
    }
}

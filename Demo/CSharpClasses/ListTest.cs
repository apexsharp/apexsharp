namespace Demo.CSharpClasses
{
    using Apex.ApexSharp.NUnit;
    using Apex.System;

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

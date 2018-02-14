using Apex.ApexSharp;
using Demo.SObjects;

namespace Demo.CSharpClasses
{
    using Apex.System;

    public class DateTimeDemo
    {
        public static void Demo()
        {
            Date myDate = Date.newInstance(1960, 2, 17);
            System.debug(myDate.ToString());
            Datetime myDateTime = Datetime.now();
            System.debug(myDateTime.ToString());
        }
    }
}

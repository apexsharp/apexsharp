namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using SObjects;

    public class ClassNoApex
    {
        // Any MetodName that starts with noApex will be commented out. In this example the whole method will be commented out.
        public static void noApexMethodOne(string name)
        {
            System.debug(name);
        }

        // Any Class name that has the NoApex name space will be commented out, in this example the line "NoApex.Serilog.LogInfo will be commneted out when we convert to Apex
        public static void methodTwo(string name)
        {
            System.debug(name);

            NoApex.Serilog.LogInfo(name);
            System.debug(name);
        }
    }
}

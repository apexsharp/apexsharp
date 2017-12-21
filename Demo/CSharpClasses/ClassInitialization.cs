namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using SObjects;

    public class ClassInitialization
    {
        public List<string> names;

        public ClassInitialization()
        {
            names = new List<string>{"a", "b", "c"};
        }

        public static Map<string, string> colorMap = new Map<string, string>();

        static ClassInitialization()
        {
            colorMap.put("red", "255, 0, 0");
            colorMap.put("cyan", "0, 255, 255");
            colorMap.put("magenta", "255, 0, 255");
        }
    }
}

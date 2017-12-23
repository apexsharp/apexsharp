namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using SObjects;

    public class ClassInterface : IClassInterface
    {
        public string getName(string name)
        {
            return name;
        }

        public string getName()
        {
            return "Jay";
        }
    }
}

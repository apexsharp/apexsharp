namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    
    using SObjects;

    /**
    * This comment belongs to the Class Syntax
     */
    [WithSharing]
    public class Comments
    {
        // This comment belongs to the Method Syntax
        public static void demoMethod()
        {
            int demoValue = 5; // Side Line Comment
        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Apex;
using Apex.ApexSharp.Implementation;
using Apex.System;

namespace AdvanceDemo
{
    public class MokSetup
    {
        public static void InitMok()
        {
            Implementor.SetImplementation<DemoApexClass>(new ApexMok.DemoApexClass());
        }

        public static void ExpandoObjectInit()
        {
            // <Jay> I do not understand the role of this code here , what issue are we trying to solve
            // <Alex> This sample demonstrates how to mock a method without creating a class like ApexImpl.UserInfo

            // Set the custom implementation using ExpandoObject
            // Suitable for simple use cases like mocking one or two static methods

            dynamic implementation = new ExpandoObject();
            implementation.StaticMethod = new Action<int, string>((i, s) => Console.WriteLine("ExpandoObject static method: {0} + {1}", i, s));
            implementation.AnotherStaticMethod = new Action<string>(s => Console.WriteLine("Hello, {0} from the ExpandoObject!", s));
            Implementor.SetImplementation<UserInfo>(implementation);
        }
    }
}

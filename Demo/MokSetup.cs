using System;
using System.Dynamic;
using Apex;
using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Demo
{
    public class MokSetup
    {
        public static void InitMok()
        {
            Implementor.SetImplementation<DemoApexClass>(new ApexMok.DemoApexClassMok());
        }

        public static void RemoveMok()
        {
            Implementor.ResetToDefault<DemoApexClass>();
        }

        public static void ExpandoObjectInit()
        {
            // Console.WriteLine();
            // Console.WriteLine("Mocking using ExpandoObject ");
            // Console.WriteLine();
            // demonstrate that the implemented methods don't fail anymore
            // UserInfo.AnotherStaticMethod("World");
            // UserInfo.StaticMethod(123, "321");

            // This sample demonstrates how to mock a method without creating a class like ApexImpl.UserInfo

            // Set the custom implementation using ExpandoObject
            // Suitable for simple use cases like mocking one or two static methods

            //dynamic implementation = new ExpandoObject();
            //implementation.StaticMethod = new Action<int, string>((i, s) => Console.WriteLine("ExpandoObject static method: {0} + {1}", i, s));
            //implementation.AnotherStaticMethod = new Action<string>(s => Console.WriteLine("Hello, {0} from the ExpandoObject!", s));
            //Implementor.SetImplementation<UserInfo>(implementation);
        }
    }
}

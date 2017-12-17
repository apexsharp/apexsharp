using System;
using System.Collections.Generic;
using System.Text;
using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex
{
    public class DemoApexClass
    {
        // infrastructure methods and properties — the same code for all API classes
        public DemoApexClass(dynamic self)
        {
            Self = self;
        }

        public dynamic Self { get; set; }

        public static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DemoApexClass));
            }
        }

        // generated API methods and properties — all follow the same pattern
        // 1) static methods use Implementation object
        // 2) instance methods use Self object
        // 3) the default stub implementation always throws a NotImplementedException

        public DemoApexClass(string name, int age)
        {
            Self = Implementation.Constructor(name, age);
        }

        public string Name
        {
            get { return Self.Name; }
            set { Self.Name = value; }
        }

        public int Age
        {
            get { return Self.Age; }
            set { Self.Age = value; }
        }

        public string NonStaticMethod()
        {
            return Self.NonStaticMethod();
        }

        public static void StaticMethod(int a, string b)
        {
            Implementation.StaticMethod(a, b);
        }

        public static void AnotherStaticMethod(string name)
        {
            Implementation.AnotherStaticMethod(name);
        }

        public static void StaticMethodMokAndReal(string name)
        {
            Implementation.StaticMethodMokAndReal(name);
        }
    }
}

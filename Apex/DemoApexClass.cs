using System;
using Apex.ApexSharp.Implementation;

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

        public static dynamic Implementation => Implementor.GetImplementation(typeof(DemoApexClass));

        // generated API methods and properties — all follow the same pattern
        // 1) static methods use Implementation object
        // 2) instance methods use Self object
        // 3) the default stub implementation always throws a NotImplementedException

        public DemoApexClass(string name, int age)
        {
            Console.WriteLine("You Called the Real Constructor");
            Self = Implementation.Constructor(name, age);
        }

        public string Name
        {
            get => Self.Name;
            set => Self.Name = value;
        }

        public int Age
        {
            get => Self.Age;
            set => Self.Age = value;
        }

        public string NonStaticMethod()
        {
            //return "Real NonStaticMethod";
            return Self.NonStaticMethod();
        }

        public static void StaticMethod(string name)
        {
            //Console.WriteLine("Real StaticMethod " +name);
            Implementation.StaticMethod(name);
        }

        public static void StaticMethodWithMokAndReal(string name)
        {
            //Console.WriteLine("Real StaticMethodWithMokAndReal " + name);
            Implementation.StaticMethodWithMokAndReal(name);
        }
    }

    [Implements(typeof(DemoApexClass))]
    public class DemoApexClassImplementation
    {
        // Self

        public class DemoApexClassInstance
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string NonStaticMethod()
            {
                return "Real NonStatic Method";
            }
        }

        // Implementation

        public dynamic Constructor(string name, int age)
        {
            return new DemoApexClassInstance { Name = name, Age = age };
        }

        public void StaticMethod(string name)
        {
            Console.WriteLine($"Real.StaticMethod: {name}");
        }

        public void AnotherStaticMethod(string name)
        {
            Console.WriteLine($"Real.AnotherStaticMethod: {name}");
        }

        public void StaticMethodWithMokAndReal(string name)
        {
            Console.WriteLine($"Real.StaticMethodWithMokAndReal: {name}");
        }
    }
}

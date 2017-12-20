using System;
using Apex.ApexSharp.Implementation;

namespace Apex
{
    public class DemoApexClass
    {
        public DemoApexClass(dynamic self)
        {
            Self = self;
        }

        public dynamic Self { get; set; }

        public static dynamic Implementation => Implementor.GetImplementation(typeof(DemoApexClass));

        public DemoApexClass(string name, int age)
        {
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
            return Self.NonStaticMethod();
        }

        public static void StaticMethod(string name)
        {
            Implementation.StaticMethod(name);
        }

        public static void AnotherStaticMethod(string name)
        {
            Implementation.AnotherStaticMethod(name);
        }

        public static void StaticMethodWithMokAndReal(string name)
        {
            Implementation.StaticMethodWithMokAndReal(name);
        }
    }

    [Implements(typeof(DemoApexClass))]
    public class DemoApexClassImplementation
    {
        public class DemoApexClassInstance
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string NonStaticMethod()
            {
                return "Real.Method";
            }
        }

        public dynamic Constructor(string name, int age)
        {
            Console.WriteLine("Real.Constructor");
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

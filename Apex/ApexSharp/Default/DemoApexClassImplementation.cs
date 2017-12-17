using Apex.ApexSharp.Implementation;
using static System.Console;

namespace Apex.ApexSharp.Default
{
    [Implements(typeof(DemoApexClass))]
    public class DemoApexClassImplementation
    {
        // Self

        public class DemoApexClassInstance
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string NonStaticMethod() => $"{GetType().Name}: Name = {Name}, Age = {Age}";
        }

        // Implementation

        public dynamic Constructor(string name, int age)
        {
            return new DemoApexClassInstance { Name = name, Age = age };
        }

        public void StaticMethod(int a, string b)
        {
            WriteLine($"Real.StaticMethod: {a}, {b}");
        }

        public void AnotherStaticMethod(string name)
        {
            WriteLine($"Real.AnotherStaticMethod: {name}");
        }

        public void StaticMethodMokAndReal(string name)
        {
            WriteLine($"Real.StaticMethodMokAndReal: {name}");
        }
    }
}

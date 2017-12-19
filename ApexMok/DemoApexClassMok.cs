using System;
using Apex.ApexSharp.Implementation;

namespace ApexMok
{
    public class DemoApexClassMok
    {
        // Self

        public class RealDemoApexClass
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string  NonStaticMethod()
            {
                return "MOK NonStaticMethod";
            }
        }

        // Implementation
        public dynamic Constructor(string name, int age)
        {
            Console.WriteLine("MOK Constructor");
            return new RealDemoApexClass { Name = name, Age = age };
        }

        public void StaticMethod(string name)
        {
            Console.WriteLine("MOK StaticMethod " + name);
        }

        // Example to show you can call Mok and based on value you can call Real
        public void StaticMethodWithMokAndReal(string name)
        {
            // If name is "apexSharpMok" stick to Mok, if not call Real
            if (name == "apexSharpMok")
            {
                Console.WriteLine("MOK StaticMethodWithMokAndReal " + name);
            }
            else
            {
                // temporarily switch the given class to the original implementation:
                using (Implementor.UseDefaultImplementation<Apex.DemoApexClass>())
                {
                    Apex.DemoApexClass.StaticMethodWithMokAndReal(name);
                }
            }
        }
    }
}

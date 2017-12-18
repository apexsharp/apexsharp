using System;
using System.Collections.Generic;
using System.Text;
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
            Console.WriteLine("You Called the Mok Constructor");
            return new RealDemoApexClass { Name = name, Age = age };
        }

        public void StaticMethod(string name)
        {
            Console.WriteLine("MOK StaticMethod " + name);
        }

        // Example to show you can call Mok and based on value you can call Real
        public void StaticMethodWithMokAndReal(string name)
        {
            // If name is Jay stick to Mok, if not call Real
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

                //// temporarily switch all API classes to their original implementations:
                //using (Implementor.UseDefaultImplementations())
                //{
                //    Apex.DemoApexClass.StaticMethodWithMokAndReal(name);
                //}

                //// temporarily switch the UserInfo to the stub implementation
                //using (Implementor.UseStubImplementation<Apex.DemoApexClass>())
                //{
                //    // throws a NotImplementedException
                //    Apex.DemoApexClass.StaticMethodWithMokAndReal(name);
                //}
            }
        }
    }
}

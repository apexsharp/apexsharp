using System;
using System.Collections.Generic;
using System.Text;
using Apex.ApexSharp.Implementation;

namespace ApexMok
{
    public class DemoApexClass
    {
        // Self

        public class RealUserInfo
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string NonStaticMethod() => $"Mok UserInfo: Name = {Name}, Age = {Age}";
        }

        // Implementation

        public ApexMok.DemoApexClass Constructor(string name, int age)
        {
            Console.WriteLine("You Called the Mok Constructor");
            dynamic self = new RealUserInfo { Name = name, Age = age };
            return new ApexMok.DemoApexClass();;
        }

        public void StaticMethod(int a, string b)
        {
            Console.WriteLine("You Called the Mok Implementation : StaticMethod");
        }

        public void AnotherStaticMethod(string name)
        {
            Console.WriteLine("You Called the Mok Implementation : AnotherStaticMethod");
        }

        // Example to show you can call Mok and based on value you can call Real
        public void StaticMethodMokAndReal(string name)
        {
            // If name is Jay stick to Mok, if not call Real
            if (name == "Jay")
            {
                Console.WriteLine("You Called the Mok Implementation : StaticMethodMokAndReal");
            }
            else
            {
                // temporarily switch the given class to the original implementation:
                using (Implementor.UseDefaultImplementation<Apex.DemoApexClass>())
                {
                    Apex.DemoApexClass.StaticMethodMokAndReal(name);
                }

                // temporarily switch all API classes to their original implementations:
                using (Implementor.UseDefaultImplementations())
                {
                    Apex.DemoApexClass.StaticMethodMokAndReal(name);
                }

                // temporarily switch the UserInfo to the stub implementation
                using (Implementor.UseStubImplementation<Apex.DemoApexClass>())
                {
                    // throws a NotImplementedException
                    Apex.DemoApexClass.StaticMethodMokAndReal(name);
                }
            }
        }
    }
}

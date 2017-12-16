using System;
using Apex.ApexSharp.Implementation;

namespace ApexImpl
{
    [Implements(typeof(Apex.UserInfo))]
    public class UserInfoImplementation
    {
        // Self

        public class RealUserInfo
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string NonStaticMethod() => $"Real UserInfo: Name = {Name}, Age = {Age}";
        }

        // Implementation

        public Apex.UserInfo Constructor(string name, int age)
        {
            Console.WriteLine("You Called the Real Construtor");
            dynamic self = new RealUserInfo { Name = name, Age = age };
            return new Apex.UserInfo(self);
        }

        public void StaticMethod(int a, string b)
        {
            Console.WriteLine("You Called the Real Implementation : StaticMethod");
        }

        public void AnotherStaticMethod(string name)
        {
            Console.WriteLine("You Called the Real Implementation : AnotherStaticMethod");
        }

        public void StaticMethodMokAndReal(string name)
        {
            Console.WriteLine("You Called the Real Implementation : StaticMethodMokAndReal");
        }
    }
}

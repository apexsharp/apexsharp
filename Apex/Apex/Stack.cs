namespace Apex.Apex
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Stack
    {
        // infrastructure
        public Stack(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Stack));
            }
        }

        // API
        public Stack()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool empty()
        {
            return Self.empty();
        }

        public string peek()
        {
            return Self.peek();
        }

        public string pop()
        {
            return Self.pop();
        }

        public void push(string item)
        {
            Self.push(item);
        }
    }
}

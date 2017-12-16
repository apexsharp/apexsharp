namespace Apex.Apex
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Stack<T>
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
                return Implementor.GetImplementation(typeof(Stack<T>));
            }
        }

        // API
        public Stack()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool empty()
        {
            return Self.empty();
        }

        public T peek()
        {
            return Self.peek();
        }

        public T pop()
        {
            return Self.pop();
        }

        public void push(T item)
        {
            Self.push(item);
        }
    }
}

namespace Apex.Apex
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmptyStackException
    {
        // infrastructure
        public EmptyStackException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmptyStackException));
            }
        }

        // API
        public EmptyStackException()
        {
            Implementation.Constructor();
        }

        public EmptyStackException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public EmptyStackException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public EmptyStackException(string param1, Exception param2)
        {
            Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}

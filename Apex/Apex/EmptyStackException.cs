namespace Apex.Apex
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmptyStackException : Exception
    {
        // infrastructure
        public EmptyStackException(dynamic self)
        {
            Self = self;
        }

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
            Self = Implementation.Constructor();
        }

        public EmptyStackException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public EmptyStackException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public EmptyStackException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public override object clone()
        {
            return Self.clone();
        }

        public override string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}

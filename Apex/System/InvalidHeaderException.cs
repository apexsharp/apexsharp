namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidHeaderException
    {
        // infrastructure
        public InvalidHeaderException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidHeaderException));
            }
        }

        // API
        public InvalidHeaderException()
        {
            Implementation.Constructor();
        }

        public InvalidHeaderException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public InvalidHeaderException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public InvalidHeaderException(string param1, Exception param2)
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

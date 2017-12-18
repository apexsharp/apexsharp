namespace Apex.Wave
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidParameterException
    {
        // infrastructure
        public InvalidParameterException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidParameterException));
            }
        }

        // API
        public InvalidParameterException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidParameterException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidParameterException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
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

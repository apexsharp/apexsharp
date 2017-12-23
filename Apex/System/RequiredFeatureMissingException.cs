namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RequiredFeatureMissingException : Exception
    {
        // infrastructure
        public RequiredFeatureMissingException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RequiredFeatureMissingException));
            }
        }

        // API
        public RequiredFeatureMissingException()
        {
            Self = Implementation.Constructor();
        }

        public RequiredFeatureMissingException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public RequiredFeatureMissingException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public RequiredFeatureMissingException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}

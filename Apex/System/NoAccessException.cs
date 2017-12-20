namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NoAccessException : Exception
    {
        // infrastructure
        public NoAccessException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NoAccessException));
            }
        }

        // API
        public NoAccessException()
        {
            Self = Implementation.Constructor();
        }
    }
}

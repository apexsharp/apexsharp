namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NoDataFoundException : Exception
    {
        // infrastructure
        public NoDataFoundException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NoDataFoundException));
            }
        }

        // API
        public NoDataFoundException()
        {
            Self = Implementation.Constructor();
        }
    }
}

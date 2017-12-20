namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NotFoundException : Exception
    {
        // infrastructure
        public NotFoundException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NotFoundException));
            }
        }

        // API
        public NotFoundException(string message)
        {
            Self = Implementation.Constructor(message);
        }
    }
}

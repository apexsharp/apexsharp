namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LicenseException : Exception
    {
        // infrastructure
        public LicenseException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LicenseException));
            }
        }

        // API
        public LicenseException()
        {
            Self = Implementation.Constructor();
        }

        public LicenseException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public LicenseException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public LicenseException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}

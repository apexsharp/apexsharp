namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeatureNotSupportedException : Exception
    {
        // infrastructure
        public FeatureNotSupportedException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeatureNotSupportedException));
            }
        }

        // API
        public FeatureNotSupportedException()
        {
            Self = Implementation.Constructor();
        }

        public FeatureNotSupportedException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public FeatureNotSupportedException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}

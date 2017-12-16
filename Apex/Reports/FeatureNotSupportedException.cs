namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeatureNotSupportedException
    {
        // infrastructure
        public FeatureNotSupportedException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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
            Implementation.Constructor();
        }

        public FeatureNotSupportedException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public FeatureNotSupportedException(string param1, Exception param2)
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

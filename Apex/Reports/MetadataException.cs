namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MetadataException : Exception
    {
        // infrastructure
        public MetadataException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MetadataException));
            }
        }

        // API
        public MetadataException()
        {
            Self = Implementation.Constructor();
        }

        public MetadataException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public MetadataException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}

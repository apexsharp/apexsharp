namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidReportMetadataException : Exception
    {
        // infrastructure
        public InvalidReportMetadataException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidReportMetadataException));
            }
        }

        // API
        public InvalidReportMetadataException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidReportMetadataException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidReportMetadataException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidReportMetadataException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public List<string> getReportMetadataErrors()
        {
            return Self.getReportMetadataErrors();
        }
    }
}

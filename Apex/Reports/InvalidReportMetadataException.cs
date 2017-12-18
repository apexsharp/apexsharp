namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidReportMetadataException
    {
        // infrastructure
        public InvalidReportMetadataException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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

        public object clone()
        {
            return Self.clone();
        }

        public List<string> getReportMetadataErrors()
        {
            return Self.getReportMetadataErrors();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}

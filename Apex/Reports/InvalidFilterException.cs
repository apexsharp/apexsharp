namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidFilterException
    {
        // infrastructure
        public InvalidFilterException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidFilterException));
            }
        }

        // API
        public InvalidFilterException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidFilterException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidFilterException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidFilterException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<string> getFilterErrors()
        {
            return Self.getFilterErrors();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}

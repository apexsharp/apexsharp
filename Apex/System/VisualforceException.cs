namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class VisualforceException : Exception
    {
        // infrastructure
        public VisualforceException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(VisualforceException));
            }
        }

        // API
        public VisualforceException()
        {
            Self = Implementation.Constructor();
        }

        public VisualforceException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public VisualforceException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public VisualforceException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}

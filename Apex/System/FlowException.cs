namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FlowException : Exception
    {
        // infrastructure
        public FlowException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FlowException));
            }
        }

        // API
        public FlowException()
        {
            Self = Implementation.Constructor();
        }

        public FlowException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public FlowException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public FlowException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}

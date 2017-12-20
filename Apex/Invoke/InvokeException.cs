namespace Apex.Invoke
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvokeException : Exception
    {
        // infrastructure
        public InvokeException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvokeException));
            }
        }

        // API
        public InvokeException()
        {
            Self = Implementation.Constructor();
        }

        public InvokeException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvokeException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvokeException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public string getErrorMessage()
        {
            return Self.getErrorMessage();
        }

        public string getErrorType()
        {
            return Self.getErrorType();
        }

        public string getStackTrace()
        {
            return Self.getStackTrace();
        }
    }
}

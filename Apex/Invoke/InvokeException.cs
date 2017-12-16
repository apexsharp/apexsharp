namespace Apex.Invoke
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvokeException
    {
        // infrastructure
        public InvokeException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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
            Implementation.Constructor();
        }

        public InvokeException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public InvokeException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public InvokeException(string param1, Exception param2)
        {
            Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
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

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}

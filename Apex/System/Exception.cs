namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Exception : global::System.Exception
    {
        // infrastructure
        public Exception(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Exception));
            }
        }

        // API
        public Exception()
        {
            Self = Implementation.Constructor();
        }

        public Exception(string message)
        {
            Self = Implementation.Constructor(message);
        }

        public Exception(string message, Exception cause)
        {
            Self = Implementation.Constructor(message, cause);
        }

        public Exception(Exception cause)
        {
            Self = Implementation.Constructor(cause);
        }

        public object clone()
        {
            return Self.clone();
        }

        public Exception getCause()
        {
            return Self.getCause();
        }

        public int getLineNumber()
        {
            return Self.getLineNumber();
        }

        public string getMessage()
        {
            return Self.getMessage();
        }

        public string getStackTraceString()
        {
            return Self.getStackTraceString();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }

        public void initCause(Exception cause)
        {
            Self.initCause(cause);
        }

        public void setMessage(string message)
        {
            Self.setMessage(message);
        }
    }
}

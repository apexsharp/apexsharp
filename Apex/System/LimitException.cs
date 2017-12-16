namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LimitException
    {
        // infrastructure
        public LimitException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LimitException));
            }
        }

        // API
        public LimitException()
        {
            Implementation.Constructor();
        }

        public LimitException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public LimitException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public LimitException(string param1, Exception param2)
        {
            Implementation.Constructor(param1, param2);
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

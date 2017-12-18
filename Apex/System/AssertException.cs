namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AssertException
    {
        // infrastructure
        public AssertException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AssertException));
            }
        }

        // API
        public AssertException()
        {
            Self = Implementation.Constructor();
        }

        public AssertException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AssertException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public AssertException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
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

namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TypeException
    {
        // infrastructure
        public TypeException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TypeException));
            }
        }

        // API
        public TypeException()
        {
            Self = Implementation.Constructor();
        }

        public TypeException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public TypeException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public TypeException(string param1, Exception param2)
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

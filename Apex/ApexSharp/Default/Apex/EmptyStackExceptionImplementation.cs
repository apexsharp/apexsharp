namespace Apex.ApexSharp.Implementation.Default.Apex
{
    using System;
    using global::Apex.Apex;

    [Implements(typeof(EmptyStackException))]
    public class EmptyStackExceptionImplementation
    {
        // Self

        public class EmptyStackExceptionInstance
        {
            public Exception Cause { get; set; }

            public Exception getCause() => Cause;

            public void initCause(Exception cause) => Cause = cause;

            public int LineNumber { get; set; }

            public int getLineNumber() => LineNumber;

            public string Message { get; set; } = "The stack is empty.";

            public string getMessage() => Message;

            public void setMessage(string message) => Message = message;

            public string StackTrace { get; set; }

            public string getStackTraceString() => StackTrace;

            public string TypeName => nameof(EmptyStackException);

            public string getTypeName() => TypeName;

            public object clone() => new EmptyStackException(this);
        }

        // Implementation

        public dynamic Constructor()
        {
            return new EmptyStackExceptionInstance();
        }

        public dynamic Constructor(string message)
        {
            return new EmptyStackExceptionInstance { Message = message };
        }

        public dynamic Constructor(Exception cause)
        {
            return new EmptyStackExceptionInstance { Cause = cause };
        }

        public dynamic Constructor(string message, Exception cause)
        {
            return new EmptyStackExceptionInstance { Message = message, Cause = cause };
        }
    }
}

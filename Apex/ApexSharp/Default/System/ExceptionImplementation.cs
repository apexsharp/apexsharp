using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Exception))]
    public class ExceptionImplementation
    {
        public class ExceptionInstance
        {
            public Exception Cause { get; set; }

            public Exception getCause() => Cause;

            public void initCause(Exception cause) => Cause = cause;

            public int LineNumber { get; set; }

            public int getLineNumber() => LineNumber;

            public string Message { get; set; } = "Exception occured.";

            public string getMessage() => Message;

            public void setMessage(string message) => Message = message;

            public string StackTrace { get; set; }

            public string getStackTraceString() => StackTrace;

            public string TypeName => nameof(Exception);

            public string getTypeName() => TypeName;

            public object clone() => new Exception(this);
        }

        public Exception Constructor()
        {
            dynamic self = new ExceptionInstance();
            return new Exception(self);
        }

        public Exception Constructor(string message)
        {
            dynamic self = new ExceptionInstance { Message = message };
            return new Exception(self);
        }

        public Exception Constructor(Exception cause)
        {
            dynamic self = new ExceptionInstance { Cause = cause };
            return new Exception(self);
        }

        public Exception Constructor(string message, Exception cause)
        {
            dynamic self = new ExceptionInstance { Message = message, Cause = cause };
            return new Exception(self);
        }
    }
}

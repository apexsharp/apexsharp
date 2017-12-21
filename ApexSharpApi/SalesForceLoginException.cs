using System;

namespace ApexSharpApi
{
    public class SalesForceInvalidLoginException : Exception
    {

        public SalesForceInvalidLoginException(string message)
        : base(message)
        {
        }

    }

    public class ApexSharpNoConfigFoundException : Exception
    {

        public ApexSharpNoConfigFoundException(string message)
        : base(message)
        {
        }

    }

    public class SalesSessionExpiredException : Exception
    {

        public SalesSessionExpiredException(string message)
        : base(message)
        {
        }

    }

    public class ApexSharpHttpException : Exception
    {

        public ApexSharpHttpException(string message)
        : base(message)
        {
        }

    }
}

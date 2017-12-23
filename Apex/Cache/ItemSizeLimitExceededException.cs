namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ItemSizeLimitExceededException : Exception
    {
        // infrastructure
        public ItemSizeLimitExceededException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ItemSizeLimitExceededException));
            }
        }

        // API
        public ItemSizeLimitExceededException()
        {
            Self = Implementation.Constructor();
        }

        public ItemSizeLimitExceededException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ItemSizeLimitExceededException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ItemSizeLimitExceededException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}

namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ItemSizeLimitExceededException
    {
        // infrastructure
        public ItemSizeLimitExceededException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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

        public object clone()
        {
            return Self.clone();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}

namespace Apex.Social
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PostAttachment
    {
        // infrastructure
        public PostAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PostAttachment));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}

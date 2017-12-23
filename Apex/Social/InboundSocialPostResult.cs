namespace Apex.Social
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InboundSocialPostResult
    {
        // infrastructure
        public InboundSocialPostResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InboundSocialPostResult));
            }
        }

        // API
        public InboundSocialPostResult()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public void setMessage(string message)
        {
            Self.setMessage(message);
        }

        public void setSuccess(bool success)
        {
            Self.setSuccess(success);
        }
    }
}

namespace Apex.NetworksPulse
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ApproveFeedItemActionControllerExtension
    {
        // infrastructure
        public ApproveFeedItemActionControllerExtension(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ApproveFeedItemActionControllerExtension));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}

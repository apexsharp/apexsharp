namespace Apex.NetworksPulse
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RemoveFlagActionsControllerExtension
    {
        // infrastructure
        public RemoveFlagActionsControllerExtension(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RemoveFlagActionsControllerExtension));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}

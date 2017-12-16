namespace Apex.NetworksPulse
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DeleteActionsControllerExtension
    {
        // infrastructure
        public DeleteActionsControllerExtension(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeleteActionsControllerExtension));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}

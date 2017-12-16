namespace Apex.Workflow
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActionDml
    {
        // infrastructure
        public ActionDml(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActionDml));
            }
        }

        // API
        public void invoke()
        {
            Self.invoke();
        }
    }
}

namespace Apex.Workflow
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Action
    {
        // infrastructure
        public Action(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Action));
            }
        }

        // API
        public List<ActionDml> invoke(Context param1)
        {
            return Self.invoke(param1);
        }
    }
}

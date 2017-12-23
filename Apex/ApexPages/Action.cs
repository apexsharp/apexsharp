namespace Apex.ApexPages
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_pages_action.htm#apex_pages_action
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
        public Action(string action)
        {
            Self = Implementation.Constructor(action);
        }

        public string getExpression()
        {
            return Self.getExpression();
        }

        public PageReference invoke()
        {
            return Self.invoke();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

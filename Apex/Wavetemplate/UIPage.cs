namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UIPage
    {
        // infrastructure
        public UIPage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UIPage));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getCondition()
        {
            return Self.getCondition();
        }

        public string getTitle()
        {
            return Self.getTitle();
        }

        public Map<string, Variable> getVariables()
        {
            return Self.getVariables();
        }

        public void setTitle(string title)
        {
            Self.setTitle(title);
        }
    }
}

namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Variable
    {
        // infrastructure
        public Variable(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Variable));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getName()
        {
            return Self.getName();
        }

        public string getVisibility()
        {
            return Self.getVisibility();
        }

        public void setVisibility(VisibilityEnum visibility)
        {
            Self.setVisibility(visibility);
        }
    }
}

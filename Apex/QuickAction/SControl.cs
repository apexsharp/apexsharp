namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Scontrol
    {
        // infrastructure
        public Scontrol(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Scontrol));
            }
        }

        // API
        public int getDisplayLines()
        {
            return Self.getDisplayLines();
        }

        public int getTabOrder()
        {
            return Self.getTabOrder();
        }

        public string getType()
        {
            return Self.getType();
        }

        public string getValue()
        {
            return Self.getValue();
        }
    }
}

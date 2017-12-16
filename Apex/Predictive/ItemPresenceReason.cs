namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class ItemPresenceReason
    {
        // infrastructure
        public ItemPresenceReason(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ItemPresenceReason));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public List<string> getItems()
        {
            return Self.getItems();
        }

        public ReasonType getType()
        {
            return Self.getType();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class WordPresenceReason
    {
        // infrastructure
        public WordPresenceReason(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(WordPresenceReason));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ReasonType getType()
        {
            return Self.getType();
        }

        public List<string> getWords()
        {
            return Self.getWords();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
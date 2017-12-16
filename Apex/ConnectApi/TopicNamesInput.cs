namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TopicNamesInput
    {
        // infrastructure
        public TopicNamesInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TopicNamesInput));
            }
        }

        // API
        object topicNames
        {
            get
            {
                return Self.topicNames;
            }
            set
            {
                Self.topicNames = value;
            }
        }

        object topicSuggestions
        {
            get
            {
                return Self.topicSuggestions;
            }
            set
            {
                Self.topicSuggestions = value;
            }
        }

        public TopicNamesInput()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}

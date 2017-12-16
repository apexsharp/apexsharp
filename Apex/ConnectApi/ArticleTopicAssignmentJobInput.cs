namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ArticleTopicAssignmentJobInput
    {
        // infrastructure
        public ArticleTopicAssignmentJobInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ArticleTopicAssignmentJobInput));
            }
        }

        // API
        object operation
        {
            get
            {
                return Self.operation;
            }
            set
            {
                Self.operation = value;
            }
        }

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

        public ArticleTopicAssignmentJobInput()
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

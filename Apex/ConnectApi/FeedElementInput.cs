namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedElementInput
    {
        // infrastructure
        public FeedElementInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedElementInput));
            }
        }

        // API
        object capabilities
        {
            get
            {
                return Self.capabilities;
            }
            set
            {
                Self.capabilities = value;
            }
        }

        object feedElementType
        {
            get
            {
                return Self.feedElementType;
            }
            set
            {
                Self.feedElementType = value;
            }
        }

        object subjectId
        {
            get
            {
                return Self.subjectId;
            }
            set
            {
                Self.subjectId = value;
            }
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

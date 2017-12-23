namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AbstractMessageBody
    {
        // infrastructure
        public AbstractMessageBody(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AbstractMessageBody));
            }
        }

        // API
        object isRichText
        {
            get
            {
                return Self.isRichText;
            }
            set
            {
                Self.isRichText = value;
            }
        }

        object messageSegments
        {
            get
            {
                return Self.messageSegments;
            }
            set
            {
                Self.messageSegments = value;
            }
        }

        object text
        {
            get
            {
                return Self.text;
            }
            set
            {
                Self.text = value;
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

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
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

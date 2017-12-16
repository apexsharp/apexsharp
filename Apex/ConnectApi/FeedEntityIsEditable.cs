namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedEntityIsEditable
    {
        // infrastructure
        public FeedEntityIsEditable(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedEntityIsEditable));
            }
        }

        // API
        object areAttachmentsEditableByMe
        {
            get
            {
                return Self.areAttachmentsEditableByMe;
            }
            set
            {
                Self.areAttachmentsEditableByMe = value;
            }
        }

        object feedEntityUrl
        {
            get
            {
                return Self.feedEntityUrl;
            }
            set
            {
                Self.feedEntityUrl = value;
            }
        }

        object isEditableByMe
        {
            get
            {
                return Self.isEditableByMe;
            }
            set
            {
                Self.isEditableByMe = value;
            }
        }

        public FeedEntityIsEditable()
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

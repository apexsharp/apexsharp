namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailAttachment
    {
        // infrastructure
        public EmailAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailAttachment));
            }
        }

        // API
        object attachment
        {
            get
            {
                return Self.attachment;
            }
            set
            {
                Self.attachment = value;
            }
        }

        object contentType
        {
            get
            {
                return Self.contentType;
            }
            set
            {
                Self.contentType = value;
            }
        }

        object fileName
        {
            get
            {
                return Self.fileName;
            }
            set
            {
                Self.fileName = value;
            }
        }

        public EmailAttachment()
        {
            Self = Implementation.Constructor();
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

namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InlineImageSegmentInput
    {
        // infrastructure
        public InlineImageSegmentInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InlineImageSegmentInput));
            }
        }

        // API
        object altText
        {
            get
            {
                return Self.altText;
            }
            set
            {
                Self.altText = value;
            }
        }

        object fileId
        {
            get
            {
                return Self.fileId;
            }
            set
            {
                Self.fileId = value;
            }
        }

        public InlineImageSegmentInput()
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

namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CommentInput
    {
        // infrastructure
        public CommentInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommentInput));
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

        object body
        {
            get
            {
                return Self.body;
            }
            set
            {
                Self.body = value;
            }
        }

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

        public CommentInput()
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

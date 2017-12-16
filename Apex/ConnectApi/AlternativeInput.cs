namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AlternativeInput
    {
        // infrastructure
        public AlternativeInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AlternativeInput));
            }
        }

        // API
        object textRepresentation
        {
            get
            {
                return Self.textRepresentation;
            }
            set
            {
                Self.textRepresentation = value;
            }
        }

        object thumbnailUrl
        {
            get
            {
                return Self.thumbnailUrl;
            }
            set
            {
                Self.thumbnailUrl = value;
            }
        }

        object title
        {
            get
            {
                return Self.title;
            }
            set
            {
                Self.title = value;
            }
        }

        public AlternativeInput()
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

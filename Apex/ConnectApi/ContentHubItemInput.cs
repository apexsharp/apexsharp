namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubItemInput
    {
        // infrastructure
        public ContentHubItemInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubItemInput));
            }
        }

        // API
        object fields
        {
            get
            {
                return Self.fields;
            }
            set
            {
                Self.fields = value;
            }
        }

        object itemTypeId
        {
            get
            {
                return Self.itemTypeId;
            }
            set
            {
                Self.itemTypeId = value;
            }
        }

        public ContentHubItemInput()
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

namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class GroupInformationInput
    {
        // infrastructure
        public GroupInformationInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GroupInformationInput));
            }
        }

        // API
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

        public GroupInformationInput()
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

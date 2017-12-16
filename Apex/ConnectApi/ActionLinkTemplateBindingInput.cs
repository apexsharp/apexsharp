namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActionLinkTemplateBindingInput
    {
        // infrastructure
        public ActionLinkTemplateBindingInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActionLinkTemplateBindingInput));
            }
        }

        // API
        object key
        {
            get
            {
                return Self.key;
            }
            set
            {
                Self.key = value;
            }
        }

        object value
        {
            get
            {
                return Self.value;
            }
            set
            {
                Self.value = value;
            }
        }

        public ActionLinkTemplateBindingInput()
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

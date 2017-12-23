namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActionLinkGroupDefinitionInput
    {
        // infrastructure
        public ActionLinkGroupDefinitionInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActionLinkGroupDefinitionInput));
            }
        }

        // API
        object actionLinks
        {
            get
            {
                return Self.actionLinks;
            }
            set
            {
                Self.actionLinks = value;
            }
        }

        object category
        {
            get
            {
                return Self.category;
            }
            set
            {
                Self.category = value;
            }
        }

        object executionsAllowed
        {
            get
            {
                return Self.executionsAllowed;
            }
            set
            {
                Self.executionsAllowed = value;
            }
        }

        object expirationDate
        {
            get
            {
                return Self.expirationDate;
            }
            set
            {
                Self.expirationDate = value;
            }
        }

        object templateBindings
        {
            get
            {
                return Self.templateBindings;
            }
            set
            {
                Self.templateBindings = value;
            }
        }

        object templateId
        {
            get
            {
                return Self.templateId;
            }
            set
            {
                Self.templateId = value;
            }
        }

        public ActionLinkGroupDefinitionInput()
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

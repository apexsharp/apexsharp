namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailHeader
    {
        // infrastructure
        public EmailHeader(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailHeader));
            }
        }

        // API
        object TriggerAutoResponseEmail
        {
            get
            {
                return Self.TriggerAutoResponseEmail;
            }
            set
            {
                Self.TriggerAutoResponseEmail = value;
            }
        }

        object TriggerOtherEmail
        {
            get
            {
                return Self.TriggerOtherEmail;
            }
            set
            {
                Self.TriggerOtherEmail = value;
            }
        }

        object TriggerUserEmail
        {
            get
            {
                return Self.TriggerUserEmail;
            }
            set
            {
                Self.TriggerUserEmail = value;
            }
        }

        public EmailHeader()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

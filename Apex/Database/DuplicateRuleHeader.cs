namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DuplicateRuleHeader
    {
        // infrastructure
        public DuplicateRuleHeader(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DuplicateRuleHeader));
            }
        }

        // API
        object AllowSave
        {
            get
            {
                return Self.AllowSave;
            }
            set
            {
                Self.AllowSave = value;
            }
        }

        object RunAsCurrentUser
        {
            get
            {
                return Self.RunAsCurrentUser;
            }
            set
            {
                Self.RunAsCurrentUser = value;
            }
        }

        public DuplicateRuleHeader()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

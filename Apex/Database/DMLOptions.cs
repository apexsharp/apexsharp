namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_database_dmloptions.htm#apex_methods_system_database_dmloptions
    /// </summary>
    public class DMLOptions
    {
        // infrastructure
        public DMLOptions(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DMLOptions));
            }
        }

        // API
        bool allowFieldTruncation
        {
            get
            {
                return Self.allowFieldTruncation;
            }
            set
            {
                Self.allowFieldTruncation = value;
            }
        }

        AssignmentRuleHeader assignmentRuleHeader
        {
            get
            {
                return Self.assignmentRuleHeader;
            }
            set
            {
                Self.assignmentRuleHeader = value;
            }
        }

        EmailHeader emailHeader
        {
            get
            {
                return Self.emailHeader;
            }
            set
            {
                Self.emailHeader = value;
            }
        }

        LocaleOptions localeOptions
        {
            get
            {
                return Self.localeOptions;
            }
            set
            {
                Self.localeOptions = value;
            }
        }

        bool optAllOrNone
        {
            get
            {
                return Self.optAllOrNone;
            }
            set
            {
                Self.optAllOrNone = value;
            }
        }

        object AllowFieldTruncation
        {
            get
            {
                return Self.AllowFieldTruncation;
            }
            set
            {
                Self.AllowFieldTruncation = value;
            }
        }

        object AssignmentRuleHeader
        {
            get
            {
                return Self.AssignmentRuleHeader;
            }
            set
            {
                Self.AssignmentRuleHeader = value;
            }
        }

        object DuplicateRuleHeader
        {
            get
            {
                return Self.DuplicateRuleHeader;
            }
            set
            {
                Self.DuplicateRuleHeader = value;
            }
        }

        object EmailHeader
        {
            get
            {
                return Self.EmailHeader;
            }
            set
            {
                Self.EmailHeader = value;
            }
        }

        object LocaleOptions
        {
            get
            {
                return Self.LocaleOptions;
            }
            set
            {
                Self.LocaleOptions = value;
            }
        }

        object LocalizeErrors
        {
            get
            {
                return Self.LocalizeErrors;
            }
            set
            {
                Self.LocalizeErrors = value;
            }
        }

        object OptAllOrNone
        {
            get
            {
                return Self.OptAllOrNone;
            }
            set
            {
                Self.OptAllOrNone = value;
            }
        }

        public DMLOptions()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

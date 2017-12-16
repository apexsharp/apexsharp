namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AssignmentRuleHeader
    {
        // infrastructure
        public AssignmentRuleHeader(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AssignmentRuleHeader));
            }
        }

        // API
        object AssignmentRuleId
        {
            get
            {
                return Self.AssignmentRuleId;
            }
            set
            {
                Self.AssignmentRuleId = value;
            }
        }

        object UseDefaultRule
        {
            get
            {
                return Self.UseDefaultRule;
            }
            set
            {
                Self.UseDefaultRule = value;
            }
        }

        public AssignmentRuleHeader()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

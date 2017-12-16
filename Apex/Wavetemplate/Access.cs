namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Access
    {
        // infrastructure
        public Access(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Access));
            }
        }

        // API
        public Access()
        {
            Implementation.Constructor();
        }

        public static List<string> checkIntegUserAccessToArrayOfSObjectFields(string variableName, WaveTemplateInfo template, Answers answers)
        {
            return Implementation.checkIntegUserAccessToArrayOfSObjectFields(variableName, template, answers);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static bool integUserHasAccessToSObjectField(string sObjectName, string fieldName)
        {
            return Implementation.integUserHasAccessToSObjectField(sObjectName, fieldName);
        }

        public static bool integUserHasAccessToSObjectField(string variableName, WaveTemplateInfo template, Answers answers)
        {
            return Implementation.integUserHasAccessToSObjectField(variableName, template, answers);
        }
    }
}

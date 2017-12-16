namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_pattern_and_matcher_pattern_methods.htm#apex_classes_pattern_and_matcher_pattern_methods
    /// </summary>
    public class Pattern
    {
        // infrastructure
        public Pattern(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Pattern));
            }
        }

        // API
        public static Pattern compile(string regExp)
        {
            return Implementation.compile(regExp);
        }

        public Matcher matcher(string regExp)
        {
            return Self.matcher(regExp);
        }

        public static bool matches(string regExp, string stringtoMatch)
        {
            return Implementation.matches(regExp, stringtoMatch);
        }

        public string pattern()
        {
            return Self.pattern();
        }

        public static string quote(string yourString)
        {
            return Implementation.quote(yourString);
        }

        public string[] split(string regExp)
        {
            return Self.split(regExp);
        }

        public string[] split(string regExp, int limit)
        {
            return Self.split(regExp, limit);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

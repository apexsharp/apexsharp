namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_pattern_and_matcher_matcher_methods.htm#apex_classes_pattern_and_matcher_matcher_methods
    /// </summary>
    public class Matcher
    {
        // infrastructure
        public Matcher(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Matcher));
            }
        }

        // API
        public int end()
        {
            return Self.end();
        }

        public int end(int groupIndex)
        {
            return Self.end(groupIndex);
        }

        public bool find()
        {
            return Self.find();
        }

        public bool find(int group)
        {
            return Self.find(group);
        }

        public string group()
        {
            return Self.group();
        }

        public string group(int groupIndex)
        {
            return Self.group(groupIndex);
        }

        public int groupCount()
        {
            return Self.groupCount();
        }

        public bool hasAnchoringBounds()
        {
            return Self.hasAnchoringBounds();
        }

        public bool hasTransparentBounds()
        {
            return Self.hasTransparentBounds();
        }

        public bool hitEnd()
        {
            return Self.hitEnd();
        }

        public bool lookingAt()
        {
            return Self.lookingAt();
        }

        public bool matches()
        {
            return Self.matches();
        }

        public Pattern pattern()
        {
            return Self.pattern();
        }

        public static string quoteReplacement(string inputString)
        {
            return Implementation.quoteReplacement(inputString);
        }

        public Matcher region(int start, int end)
        {
            return Self.region(start, end);
        }

        public int regionEnd()
        {
            return Self.regionEnd();
        }

        public int regionStart()
        {
            return Self.regionStart();
        }

        public string replaceAll(string replacementString)
        {
            return Self.replaceAll(replacementString);
        }

        public string replaceFirst(string replacementString)
        {
            return Self.replaceFirst(replacementString);
        }

        public bool requireEnd()
        {
            return Self.requireEnd();
        }

        public Matcher reset()
        {
            return Self.reset();
        }

        public Matcher reset(string inputSequence)
        {
            return Self.reset(inputSequence);
        }

        public int start()
        {
            return Self.start();
        }

        public int start(int groupIndex)
        {
            return Self.start(groupIndex);
        }

        public Matcher useAnchoringBounds(bool anchoringBounds)
        {
            return Self.useAnchoringBounds(anchoringBounds);
        }

        public Matcher usePattern(Pattern pattern)
        {
            return Self.usePattern(pattern);
        }

        public Matcher useTransparentBounds(bool transparentBounds)
        {
            return Self.useTransparentBounds(transparentBounds);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

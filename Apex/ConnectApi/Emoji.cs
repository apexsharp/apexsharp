namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Emoji
    {
        // infrastructure
        public Emoji(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Emoji));
            }
        }

        // API
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

        object shortcut
        {
            get
            {
                return Self.shortcut;
            }
            set
            {
                Self.shortcut = value;
            }
        }

        object unicodeCharacter
        {
            get
            {
                return Self.unicodeCharacter;
            }
            set
            {
                Self.unicodeCharacter = value;
            }
        }

        public Emoji()
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

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
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

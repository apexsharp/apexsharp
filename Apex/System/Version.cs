namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_version.htm#apex_methods_system_version
    /// </summary>
    public class Version
    {
        // infrastructure
        public Version(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Version));
            }
        }

        // API
        public Version(int major, int minor)
        {
            Self = Implementation.Constructor(major, minor);
        }

        public Version(int major, int minor, int patch)
        {
            Self = Implementation.Constructor(major, minor, patch);
        }

        public int compareTo(Version version)
        {
            return Self.compareTo(version);
        }

        public int major()
        {
            return Self.major();
        }

        public int minor()
        {
            return Self.minor();
        }

        public int patch()
        {
            return Self.patch();
        }
    }
}

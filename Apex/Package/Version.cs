namespace Apex.Package
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
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
        public bool isGreaterThan(Version other)
        {
            return Self.isGreaterThan(other);
        }

        public bool isGreaterThanOrEqual(Version other)
        {
            return Self.isGreaterThanOrEqual(other);
        }

        public bool isLessThan(Version other)
        {
            return Self.isLessThan(other);
        }

        public bool isLessThanOrEqual(Version other)
        {
            return Self.isLessThanOrEqual(other);
        }
    }
}

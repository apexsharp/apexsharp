namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailMergeFieldInfo
    {
        // infrastructure
        public EmailMergeFieldInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailMergeFieldInfo));
            }
        }

        // API
        object entityToMergeFieldsMap
        {
            get
            {
                return Self.entityToMergeFieldsMap;
            }
            set
            {
                Self.entityToMergeFieldsMap = value;
            }
        }

        public EmailMergeFieldInfo()
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

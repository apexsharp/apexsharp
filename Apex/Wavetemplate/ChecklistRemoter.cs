namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChecklistRemoter
    {
        // infrastructure
        public ChecklistRemoter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChecklistRemoter));
            }
        }

        // API
        public ChecklistRemoter()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Map<string, object> configuration()
        {
            return Implementation.configuration();
        }

        public static Map<string, object> dataInconsistencies()
        {
            return Implementation.dataInconsistencies();
        }

        public static Map<string, object> dataOk()
        {
            return Implementation.dataOk();
        }

        public static Map<string, object> fieldAccess()
        {
            return Implementation.fieldAccess();
        }

        public static Map<string, object> objectUsage()
        {
            return Implementation.objectUsage();
        }
    }
}

namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ServiceChecklistRemoter
    {
        // infrastructure
        public ServiceChecklistRemoter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ServiceChecklistRemoter));
            }
        }

        // API
        public ServiceChecklistRemoter()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Map<string, object> configuration(bool isCustomReset)
        {
            return Implementation.configuration(isCustomReset);
        }

        public static Map<string, object> dataInconsistencies(bool isCustomReset)
        {
            return Implementation.dataInconsistencies(isCustomReset);
        }

        public static Map<string, object> dataOk(bool isCustomReset)
        {
            return Implementation.dataOk(isCustomReset);
        }

        public static Map<string, object> fieldAccess(bool isCustomReset)
        {
            return Implementation.fieldAccess(isCustomReset);
        }

        public static Map<string, object> objectUsage(bool isCustomReset)
        {
            return Implementation.objectUsage(isCustomReset);
        }
    }
}

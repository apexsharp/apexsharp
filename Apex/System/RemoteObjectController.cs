namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_system_remoteobjectcontroller.htm#apex_methods_system_remoteobjectcontroller
    /// </summary>
    public class RemoteObjectController
    {
        // infrastructure
        public RemoteObjectController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RemoteObjectController));
            }
        }

        // API
        public static Map<string, object> create(string type, Map<string, object> fields)
        {
            return Implementation.create(type, fields);
        }

        public static Map<string, object> del(string type, List<string> recordIds)
        {
            return Implementation.del(type, recordIds);
        }

        public static Map<string, object> retrieve(string type, List<string> fields, Map<string, object> criteria)
        {
            return Implementation.retrieve(type, fields, criteria);
        }

        public static Map<string, object> updat(string type, List<string> recordIds, Map<string, object> fields)
        {
            return Implementation.updat(type, recordIds, fields);
        }

        public RemoteObjectController()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

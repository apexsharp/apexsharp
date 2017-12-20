namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_FindDuplicatesByIds.htm#apex_class_Datacloud_FindDuplicatesByIds
    /// </summary>
    public class FindDuplicatesByIds
    {
        // infrastructure
        public FindDuplicatesByIds(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FindDuplicatesByIds));
            }
        }

        // API
        public static List<FindDuplicatesResult> findDuplicatesByIds(List<ID> ids)
        {
            return Implementation.findDuplicatesByIds(ids);
        }

        public FindDuplicatesByIds()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

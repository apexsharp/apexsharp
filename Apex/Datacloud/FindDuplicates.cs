namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_FindDuplicates.htm#apex_class_Datacloud_FindDuplicates
    /// </summary>
    public class FindDuplicates
    {
        // infrastructure
        public FindDuplicates(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FindDuplicates));
            }
        }

        // API
        public static List<FindDuplicatesResult> findDuplicates(List<SObject> sObjects)
        {
            return Implementation.findDuplicates(sObjects);
        }

        public FindDuplicates()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

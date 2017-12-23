namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ManagedTopics_static_methods.htm#apex_ConnectAPI_ManagedTopics_static_methods
    /// </summary>
    public class ManagedTopics
    {
        // infrastructure
        public ManagedTopics(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ManagedTopics));
            }
        }

        // API
        public static ManagedTopic createManagedTopic(string communityId, string recordId, ManagedTopicType managedTopicType)
        {
            return Implementation.createManagedTopic(communityId, recordId, managedTopicType);
        }

        public static ManagedTopic createManagedTopic(string communityId, string recordId, ManagedTopicType managedTopicType, string parentId)
        {
            return Implementation.createManagedTopic(communityId, recordId, managedTopicType, parentId);
        }

        public static ManagedTopic createManagedTopicByName(string communityId, string name, ManagedTopicType managedTopicType)
        {
            return Implementation.createManagedTopicByName(communityId, name, managedTopicType);
        }

        public static ManagedTopic createManagedTopicByName(string communityId, string name, ManagedTopicType managedTopicType, string parentId)
        {
            return Implementation.createManagedTopicByName(communityId, name, managedTopicType, parentId);
        }

        public static void deleteManagedTopic(string communityId, string managedTopicId)
        {
            Implementation.deleteManagedTopic(communityId, managedTopicId);
        }

        public static ManagedTopic getManagedTopic(string communityId, string managedTopicId)
        {
            return Implementation.getManagedTopic(communityId, managedTopicId);
        }

        public static ManagedTopic getManagedTopic(string communityId, string managedTopicId, int depth)
        {
            return Implementation.getManagedTopic(communityId, managedTopicId, depth);
        }

        public static ManagedTopicCollection getManagedTopics(string communityId)
        {
            return Implementation.getManagedTopics(communityId);
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType)
        {
            return Implementation.getManagedTopics(communityId, managedTopicType);
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType, int depth)
        {
            return Implementation.getManagedTopics(communityId, managedTopicType, depth);
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType, string recordId, int depth)
        {
            return Implementation.getManagedTopics(communityId, managedTopicType, recordId, depth);
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType, List<string> recordIds, int depth)
        {
            return Implementation.getManagedTopics(communityId, managedTopicType, recordIds, depth);
        }

        public static ManagedTopicCollection reorderManagedTopics(string communityId, ManagedTopicPositionCollectionInput managedTopicPositionCollection)
        {
            return Implementation.reorderManagedTopics(communityId, managedTopicPositionCollection);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

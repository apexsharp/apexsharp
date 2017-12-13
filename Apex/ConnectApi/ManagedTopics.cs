using Apex.System;

namespace Apex.ConnectApi
{
    public class ManagedTopics
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("ManagedTopics.Clone");
        }

        public static ManagedTopic createManagedTopic(string communityId, string recordId,
            ManagedTopicType managedTopicType)
        {
            throw new global::System.NotImplementedException("ManagedTopics.CreateManagedTopic");
        }

        public static ManagedTopic createManagedTopic(string communityId, string recordId,
            ManagedTopicType managedTopicType, string parentId)
        {
            throw new global::System.NotImplementedException("ManagedTopics.CreateManagedTopic");
        }

        public static ManagedTopic createManagedTopicByName(string communityId, string name,
            ManagedTopicType managedTopicType)
        {
            throw new global::System.NotImplementedException("ManagedTopics.CreateManagedTopicByName");
        }

        public static ManagedTopic createManagedTopicByName(string communityId, string name,
            ManagedTopicType managedTopicType, string parentId)
        {
            throw new global::System.NotImplementedException("ManagedTopics.CreateManagedTopicByName");
        }

        public static void deleteManagedTopic(string communityId, string managedTopicId)
        {
            throw new global::System.NotImplementedException("ManagedTopics.DeleteManagedTopic");
        }

        public static ManagedTopic getManagedTopic(string communityId, string managedTopicId)
        {
            throw new global::System.NotImplementedException("ManagedTopics.GetManagedTopic");
        }

        public static ManagedTopic getManagedTopic(string communityId, string managedTopicId, int depth)
        {
            throw new global::System.NotImplementedException("ManagedTopics.GetManagedTopic");
        }

        public static ManagedTopicCollection getManagedTopics(string communityId)
        {
            throw new global::System.NotImplementedException("ManagedTopics.GetManagedTopics");
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType)
        {
            throw new global::System.NotImplementedException("ManagedTopics.GetManagedTopics");
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType,
            int depth)
        {
            throw new global::System.NotImplementedException("ManagedTopics.GetManagedTopics");
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType,
            List<string> recordIds, int depth)
        {
            throw new global::System.NotImplementedException("ManagedTopics.GetManagedTopics");
        }

        public static ManagedTopicCollection getManagedTopics(string communityId, ManagedTopicType managedTopicType,
            string recordId, int depth)
        {
            throw new global::System.NotImplementedException("ManagedTopics.GetManagedTopics");
        }

        public static ManagedTopicCollection reorderManagedTopics(string communityId,
            ManagedTopicPositionCollectionInput managedTopicPositionCollection)
        {
            throw new global::System.NotImplementedException("ManagedTopics.ReorderManagedTopics");
        }
    }
}
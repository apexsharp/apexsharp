using Apex.System;

namespace Apex.Cache
{
    public class OrgPartition
    {
        public OrgPartition(string fullyQualifiedPartitionName)
        {
            throw new global::System.NotImplementedException("OrgPartition");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("OrgPartition.Clone");
        }

        public bool contains(string key)
        {
            throw new global::System.NotImplementedException("OrgPartition.Contains");
        }

        public static string createFullyQualifiedKey(string namespaceApex, string partition, string key)
        {
            throw new global::System.NotImplementedException("OrgPartition.CreateFullyQualifiedKey");
        }

        public static string createFullyQualifiedPartition(string namespaceApex, string partition)
        {
            throw new global::System.NotImplementedException("OrgPartition.CreateFullyQualifiedPartition");
        }

        public object get(string key)
        {
            throw new global::System.NotImplementedException("OrgPartition.Get");
        }

        public long getAvgGetTime()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetAvgGetTime");
        }

        public long getAvgValueSize()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetAvgValueSize");
        }

        public double getCapacity()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetCapacity");
        }

        public Set<String> getKeys()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetKeys");
        }

        public long getMaxGetTime()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetMaxGetTime");
        }

        public long getMaxValueSize()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetMaxValueSize");
        }

        public double getMissRate()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetMissRate");
        }

        public string getName()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetName");
        }

        public long getNumKeys()
        {
            throw new global::System.NotImplementedException("OrgPartition.GetNumKeys");
        }

        public bool isAvailable()
        {
            throw new global::System.NotImplementedException("OrgPartition.IsAvailable");
        }

        public void put(string key, object value)
        {
            throw new global::System.NotImplementedException("OrgPartition.Put");
        }

        public void put(string key, object value, int ttlSecs)
        {
            throw new global::System.NotImplementedException("OrgPartition.Put");
        }

        public void put(string key, object value, int ttlSecs, Cache.Visibility visibility, bool immutable)
        {
            throw new global::System.NotImplementedException("OrgPartition.Put");
        }

        public void put(string key, object value, Cache.Visibility visibility)
        {
            throw new global::System.NotImplementedException("OrgPartition.Put");
        }

        public bool remove(string key)
        {
            throw new global::System.NotImplementedException("OrgPartition.Remove");
        }

        public static void validateKey(bool isDefault, string key)
        {
            throw new global::System.NotImplementedException("OrgPartition.ValidateKey");
        }

        public static void validateKeyValue(bool isDefault, string key, object value)
        {
            throw new global::System.NotImplementedException("OrgPartition.ValidateKeyValue");
        }

        public static void validateKeys(bool isDefault, List<string> keys)
        {
            throw new global::System.NotImplementedException("OrgPartition.ValidateKeys");
        }

        public static void validatePartitionName(string name)
        {
            throw new global::System.NotImplementedException("OrgPartition.ValidatePartitionName");
        }
    }
}
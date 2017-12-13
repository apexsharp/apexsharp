using Apex.System;

namespace Apex.Cache
{
    public class SessionPartition
    {
        public SessionPartition(string fullyQualifiedPartitionName)
        {
            throw new global::System.NotImplementedException("SessionPartition");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("SessionPartition.Clone");
        }

        public bool contains(string key)
        {
            throw new global::System.NotImplementedException("SessionPartition.Contains");
        }

        public static string createFullyQualifiedKey(string namespaceApex, string partition, string key)
        {
            throw new global::System.NotImplementedException("SessionPartition.CreateFullyQualifiedKey");
        }

        public static string createFullyQualifiedPartition(string namespaceApex, string partition)
        {
            throw new global::System.NotImplementedException("SessionPartition.CreateFullyQualifiedPartition");
        }

        public object get(string key)
        {
            throw new global::System.NotImplementedException("SessionPartition.Get");
        }

        public long getAvgGetTime()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetAvgGetTime");
        }

        public long getAvgValueSize()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetAvgValueSize");
        }

        public double getCapacity()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetCapacity");
        }

        public Set<String> getKeys()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetKeys");
        }

        public long getMaxGetTime()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetMaxGetTime");
        }

        public long getMaxValueSize()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetMaxValueSize");
        }

        public double getMissRate()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetMissRate");
        }

        public string getName()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetName");
        }

        public long getNumKeys()
        {
            throw new global::System.NotImplementedException("SessionPartition.GetNumKeys");
        }

        public bool isAvailable()
        {
            throw new global::System.NotImplementedException("SessionPartition.IsAvailable");
        }

        public void put(string key, object value)
        {
            throw new global::System.NotImplementedException("SessionPartition.Put");
        }

        public void put(string key, object value, int ttlSecs)
        {
            throw new global::System.NotImplementedException("SessionPartition.Put");
        }

        public void put(string key, object value, int ttlSecs, Cache.Visibility visibility, bool immutable)
        {
            throw new global::System.NotImplementedException("SessionPartition.Put");
        }

        public void put(string key, object value, Cache.Visibility visibility)
        {
            throw new global::System.NotImplementedException("SessionPartition.Put");
        }

        public bool remove(string key)
        {
            throw new global::System.NotImplementedException("SessionPartition.Remove");
        }

        public static void validateKey(bool isDefault, string key)
        {
            throw new global::System.NotImplementedException("SessionPartition.ValidateKey");
        }

        public static void validateKeyValue(bool isDefault, string key, object value)
        {
            throw new global::System.NotImplementedException("SessionPartition.ValidateKeyValue");
        }

        public static void validateKeys(bool isDefault, List<string> keys)
        {
            throw new global::System.NotImplementedException("SessionPartition.ValidateKeys");
        }

        public static void validatePartitionName(string name)
        {
            throw new global::System.NotImplementedException("SessionPartition.ValidatePartitionName");
        }
    }
}
using Apex.System;

namespace Apex.Cache
{
    public class Partition
    {
        public Partition()
        {
            throw new global::System.NotImplementedException("Partition");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("Partition.Clone");
        }

        public bool contains(string key)
        {
            throw new global::System.NotImplementedException("Partition.Contains");
        }

        public static string createFullyQualifiedKey(string namespaceApex, string partition, string key)
        {
            throw new global::System.NotImplementedException("Partition.CreateFullyQualifiedKey");
        }

        public static string createFullyQualifiedPartition(string namespaceApex, string partition)
        {
            throw new global::System.NotImplementedException("Partition.CreateFullyQualifiedPartition");
        }

        public object get(string key)
        {
            throw new global::System.NotImplementedException("Partition.Get");
        }

        public long getAvgGetTime()
        {
            throw new global::System.NotImplementedException("Partition.GetAvgGetTime");
        }

        public long getAvgValueSize()
        {
            throw new global::System.NotImplementedException("Partition.GetAvgValueSize");
        }

        public double getCapacity()
        {
            throw new global::System.NotImplementedException("Partition.GetCapacity");
        }

        public Set<String> getKeys()
        {
            throw new global::System.NotImplementedException("Partition.GetKeys");
        }

        public long getMaxGetTime()
        {
            throw new global::System.NotImplementedException("Partition.GetMaxGetTime");
        }

        public long getMaxValueSize()
        {
            throw new global::System.NotImplementedException("Partition.GetMaxValueSize");
        }

        public double getMissRate()
        {
            throw new global::System.NotImplementedException("Partition.GetMissRate");
        }

        public string getName()
        {
            throw new global::System.NotImplementedException("Partition.GetName");
        }

        public long getNumKeys()
        {
            throw new global::System.NotImplementedException("Partition.GetNumKeys");
        }

        public bool isAvailable()
        {
            throw new global::System.NotImplementedException("Partition.IsAvailable");
        }

        public void put(string key, object value)
        {
            throw new global::System.NotImplementedException("Partition.Put");
        }

        public void put(string key, object value, int ttlSecs)
        {
            throw new global::System.NotImplementedException("Partition.Put");
        }

        public void put(string key, object value, int ttlSecs, Cache.Visibility visibility, bool immutable)
        {
            throw new global::System.NotImplementedException("Partition.Put");
        }

        public void put(string key, object value, Cache.Visibility visibility)
        {
            throw new global::System.NotImplementedException("Partition.Put");
        }

        public bool remove(string key)
        {
            throw new global::System.NotImplementedException("Partition.Remove");
        }

        public static void validateKey(bool isDefault, string key)
        {
            throw new global::System.NotImplementedException("Partition.ValidateKey");
        }

        public static void validateKeyValue(bool isDefault, string key, object value)
        {
            throw new global::System.NotImplementedException("Partition.ValidateKeyValue");
        }

        public static void validateKeys(bool isDefault, List<string> keys)
        {
            throw new global::System.NotImplementedException("Partition.ValidateKeys");
        }

        public static void validatePartitionName(string name)
        {
            throw new global::System.NotImplementedException("Partition.ValidatePartitionName");
        }
    }
}
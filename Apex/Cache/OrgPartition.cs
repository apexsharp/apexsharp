namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class OrgPartition
    {
        // infrastructure
        public OrgPartition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OrgPartition));
            }
        }

        // API
        public OrgPartition(string fullyQualifiedPartitionName)
        {
            Self = Implementation.Constructor(fullyQualifiedPartitionName);
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool contains(string key)
        {
            return Self.contains(key);
        }

        public static string createFullyQualifiedKey(string @namespace, string partition, string key)
        {
            return Implementation.createFullyQualifiedKey(@namespace, partition, key);
        }

        public static string createFullyQualifiedPartition(string @namespace, string partition)
        {
            return Implementation.createFullyQualifiedPartition(@namespace, partition);
        }

        public object get(string key)
        {
            return Self.get(key);
        }

        public object get(Type cacheBuilder, string key)
        {
            return Self.get(cacheBuilder, key);
        }

        public long getAvgGetTime()
        {
            return Self.getAvgGetTime();
        }

        public long getAvgValueSize()
        {
            return Self.getAvgValueSize();
        }

        public double getCapacity()
        {
            return Self.getCapacity();
        }

        public Set<string> getKeys()
        {
            return Self.getKeys();
        }

        public long getMaxGetTime()
        {
            return Self.getMaxGetTime();
        }

        public long getMaxValueSize()
        {
            return Self.getMaxValueSize();
        }

        public double getMissRate()
        {
            return Self.getMissRate();
        }

        public string getName()
        {
            return Self.getName();
        }

        public long getNumKeys()
        {
            return Self.getNumKeys();
        }

        public bool isAvailable()
        {
            return Self.isAvailable();
        }

        public void put(string key, object value, int ttlSecs, Visibility visibility, bool immutable)
        {
            Self.put(key, value, ttlSecs, visibility, immutable);
        }

        public void put(string key, object value, int ttlSecs)
        {
            Self.put(key, value, ttlSecs);
        }

        public void put(string key, object value, Visibility visibility)
        {
            Self.put(key, value, visibility);
        }

        public void put(string key, object value)
        {
            Self.put(key, value);
        }

        public bool remove(string key)
        {
            return Self.remove(key);
        }

        public bool remove(Type cacheBuilder, string key)
        {
            return Self.remove(cacheBuilder, key);
        }

        public static void validateCacheBuilder(Type cacheBuilder)
        {
            Implementation.validateCacheBuilder(cacheBuilder);
        }

        public static void validateKey(bool isDefault, string key)
        {
            Implementation.validateKey(isDefault, key);
        }

        public static void validateKeys(bool isDefault, List<string> keys)
        {
            Implementation.validateKeys(isDefault, keys);
        }

        public static void validateKeyValue(bool isDefault, string key, object value)
        {
            Implementation.validateKeyValue(isDefault, key, value);
        }

        public static void validatePartitionName(string name)
        {
            Implementation.validatePartitionName(name);
        }
    }
}

namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_cache_Session.htm#apex_class_cache_Session
    /// </summary>
    public class Session
    {
        // infrastructure
        public Session(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Session));
            }
        }

        // API
        public static bool contains(string key)
        {
            return Implementation.contains(key);
        }

        public static object get(string key)
        {
            return Implementation.get(key);
        }

        public static object get(Type cacheBuilder, string key)
        {
            return Implementation.get(cacheBuilder, key);
        }

        public static long getAvgGetTime()
        {
            return Implementation.getAvgGetTime();
        }

        public static long getAvgValueSize()
        {
            return Implementation.getAvgValueSize();
        }

        public static double getCapacity()
        {
            return Implementation.getCapacity();
        }

        public static Set<string> getKeys()
        {
            return Implementation.getKeys();
        }

        public static long getMaxGetTime()
        {
            return Implementation.getMaxGetTime();
        }

        public static long getMaxValueSize()
        {
            return Implementation.getMaxValueSize();
        }

        public static double getMissRate()
        {
            return Implementation.getMissRate();
        }

        public string getName()
        {
            return Self.getName();
        }

        public static long getNumKeys()
        {
            return Implementation.getNumKeys();
        }

        public static SessionPartition getPartition(string partitionName)
        {
            return Implementation.getPartition(partitionName);
        }

        public static bool isAvailable()
        {
            return Implementation.isAvailable();
        }

        public static void put(string key, object value)
        {
            Implementation.put(key, value);
        }

        public static void put(string key, object value, Visibility visibility)
        {
            Implementation.put(key, value, visibility);
        }

        public static void put(string key, object value, int ttlSecs)
        {
            Implementation.put(key, value, ttlSecs);
        }

        public static void put(string key, object value, int ttlSecs, Visibility visibility, bool immutable)
        {
            Implementation.put(key, value, ttlSecs, visibility, immutable);
        }

        public static bool remove(string key)
        {
            return Implementation.remove(key);
        }

        public static bool remove(Type cacheBuilder, string key)
        {
            return Implementation.remove(cacheBuilder, key);
        }

        object MAX_TTL_SECS
        {
            get
            {
                return Self.MAX_TTL_SECS;
            }
            set
            {
                Self.MAX_TTL_SECS = value;
            }
        }

        public Session()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}

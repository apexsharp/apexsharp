using Apex.System;

namespace Apex.Cache
{
    public class Session
    {
        public Session()
        {
            throw new global::System.NotImplementedException("Session");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("Session.Clone");
        }

        public static bool contains(string key)
        {
            throw new global::System.NotImplementedException("Session.Contains");
        }

        public static object get(string key)
        {
            throw new global::System.NotImplementedException("Session.Get");
        }

        public static long getAvgGetTime()
        {
            throw new global::System.NotImplementedException("Session.GetAvgGetTime");
        }

        public static long getAvgValueSize()
        {
            throw new global::System.NotImplementedException("Session.GetAvgValueSize");
        }

        public static double getCapacity()
        {
            throw new global::System.NotImplementedException("Session.GetCapacity");
        }

        public static Set<String> getKeys()
        {
            throw new global::System.NotImplementedException("Session.GetKeys");
        }

        public static long getMaxGetTime()
        {
            throw new global::System.NotImplementedException("Session.GetMaxGetTime");
        }

        public static long getMaxValueSize()
        {
            throw new global::System.NotImplementedException("Session.GetMaxValueSize");
        }

        public static double getMissRate()
        {
            throw new global::System.NotImplementedException("Session.GetMissRate");
        }

        public static string getName()
        {
            throw new global::System.NotImplementedException("Session.GetName");
        }

        public static long getNumKeys()
        {
            throw new global::System.NotImplementedException("Session.GetNumKeys");
        }

        public static Cache.SessionPartition getPartition(string partitionName)
        {
            throw new global::System.NotImplementedException("Session.GetPartition");
        }

        public static bool isAvailable()
        {
            throw new global::System.NotImplementedException("Session.IsAvailable");
        }

        public static void put(string key, object value)
        {
            throw new global::System.NotImplementedException("Session.Put");
        }

        public static void put(string key, object value, int ttlSecs)
        {
            throw new global::System.NotImplementedException("Session.Put");
        }

        public static void put(string key, object value, int ttlSecs, Cache.Visibility visibility, bool immutable)
        {
            throw new global::System.NotImplementedException("Session.Put");
        }

        public static void put(string key, object value, Cache.Visibility visibility)
        {
            throw new global::System.NotImplementedException("Session.Put");
        }

        public static bool remove(string key)
        {
            throw new global::System.NotImplementedException("Session.Remove");
        }
    }
}
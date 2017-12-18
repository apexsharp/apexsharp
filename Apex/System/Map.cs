namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_map.htm#apex_methods_system_map
    /// </summary>
    public class Map<T1, T2>
    {
        // infrastructure
        public Map(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Map<T1, T2>));
            }
        }

        // API
        public Map()
        {
            Self = Implementation.Constructor();
        }

        public Map(Map<T1, T2> mapToCopy)
        {
            Self = Implementation.Constructor(mapToCopy);
        }

        public Map(List<SObject> recordList)
        {
            Self = Implementation.Constructor(recordList);
        }

        public void clear()
        {
            Self.clear();
        }

        public Map<object, object> clone()
        {
            return Self.clone();
        }

        public bool containsKey(object key)
        {
            return Self.containsKey(key);
        }

        public Map<object, object> deepClone()
        {
            return Self.deepClone();
        }

        public bool equals(Map<T1, T2> map2)
        {
            return Self.equals(map2);
        }

        public object get(object key)
        {
            return Self.get(key);
        }

        public SObjectType getSObjectType()
        {
            return Self.getSObjectType();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public bool isEmpty()
        {
            return Self.isEmpty();
        }

        public Set<object> keySet()
        {
            return Self.keySet();
        }

        public object put(object key, object value)
        {
            return Self.put(key, value);
        }

        public void putAll(Map<T1, T2> fromMap)
        {
            Self.putAll(fromMap);
        }

        public void putAll(SObject[] sobjectArray)
        {
            Self.putAll(sobjectArray);
        }

        public object remove(T1 key)
        {
            return Self.remove(key);
        }

        public int size()
        {
            return Self.size();
        }

        public List<object> values()
        {
            return Self.values();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public void putAll(List<SObject> entries)
        {
            Self.putAll(entries);
        }

        public string remove(object key)
        {
            return Self.remove(key);
        }
    }
}

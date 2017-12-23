namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Schema;
    using global::Apex.System;
    using global::System.Collections.Generic;
    using IEnumerable = global::System.Collections.IEnumerable;
    using IEnumerator = global::System.Collections.IEnumerator;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_map.htm#apex_methods_system_map
    /// </summary>
    public class Map<T1, T2> : IEnumerable<KeyValuePair<T1, T2>>
    {
        // infrastructure
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

        public Map(IEnumerable<KeyValuePair<T1, T2>> dictionary)
        {
            Self = Implementation.Constructor(dictionary);
        }

        public Map(List<SObject> recordList)
        {
            Self = Implementation.Constructor(recordList);
        }

        public Map(ApexSharpApi.SoqlQuery<T2> soqlQuery)
        {
            Self = Implementation.Constructor(soqlQuery);
        }

        public void clear()
        {
            Self.clear();
        }

        public Map<T1, T2> clone()
        {
            return Self.clone();
        }

        public bool containsKey(T1 key)
        {
            return Self.containsKey(key);
        }

        public Map<T1, T2> deepClone()
        {
            return Self.deepClone();
        }

        public bool equals(Map<T1, T2> map2)
        {
            return Self.equals(map2);
        }

        public T2 get(T1 key)
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

        public Set<T1> keySet()
        {
            return Self.keySet();
        }

        public T2 put(T1 key, T2 value)
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

        public void putAll(List<SObject> entries)
        {
            Self.putAll(entries);
        }

        public T2 remove(T1 key)
        {
            return Self.remove(key);
        }

        public int size()
        {
            return Self.size();
        }

        public List<T2> values()
        {
            return Self.values();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        // interoperability

        public IEnumerator<KeyValuePair<T1, T2>> GetEnumerator() => Self.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Add(T1 key, T2 value) => put(key, value);

        public T2 this[T1 key] => get(key);

        public override bool Equals(object obj) => equals(obj);

        public override int GetHashCode() => hashCode();
    }
}

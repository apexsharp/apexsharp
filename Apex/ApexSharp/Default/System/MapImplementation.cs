using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Apex.ApexSharp.Implementation;
using Apex.Schema;
using Apex.System;
using ApexSharpApi;
using NotSupportedException = System.NotSupportedException;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Map<,>))]
    public class MapImplementation<T1Outer, T2Outer>
    {
        // Self

        public class MapInstance<T1, T2> : IEnumerable<KeyValuePair<T1, T2>>
        {
            private dynamic NotImplemented { get; } = new StubImplementation(typeof(Map<T1, T2>));

            private Dictionary<T1, T2> map;

            public MapInstance() => map = new Dictionary<T1, T2>();

            public MapInstance(IEnumerable<KeyValuePair<T1, T2>> dictionary) => map = dictionary.ToDictionary(p => p.Key, p => p.Value);

            public MapInstance(MapInstance<T1, T2> mapToCopy) => map = mapToCopy.ToDictionary(p => p.Key, p => p.Value);

            public MapInstance(Map<T1, T2> mapToCopy) => map = mapToCopy.ToDictionary(p => p.Key, p => p.Value);

            public MapInstance(global::Apex.System.List<T2> recordList) : this()
            {
                AddItems(recordList);
            }

            public MapInstance(SoqlQuery<T2> soqlQuery) : this()
            {
                ValidateGenericTypeParameters();
                AddItems(soqlQuery.QueryResult.Value);
            }

            private void ValidateGenericTypeParameters()
            {
                // make sure that Map<T1, T2> is Map<ID, SObject>
                if (!typeof(SObject).IsAssignableFrom(typeof(T2)) || !typeof(ID).IsAssignableFrom(typeof(T1)))
                {
                    throw new NotSupportedException("Only Map<ID, SObject> can be initialized via List<SObject> or SOQL query data.");
                }
            }

            public void clear() => map.Clear();

            public Map<T1, T2> clone() => new Map<T1, T2>(map);

            public bool containsKey(T1 key) => map.ContainsKey(key);

            public Map<T1, T2> deepClone() => clone();

            public bool equals(Map<T1, T2> other)
            {
                if (other.size() != map.Count)
                {
                    return false;
                }

                foreach (var pair in map)
                {
                    var value = other.get(pair.Key);
                    if (!Equals(pair.Value, value))
                    {
                        return false;
                    }
                }

                return true;
            }

            public bool equals(object obj)
            {
                var other = obj as Map<T1, T2>;
                if (other == null)
                {
                    return false;
                }

                return equals(other);
            }

            public T2 get(T1 key) => map[key];

            public SObjectType getSObjectType() => NotImplemented.getSObjectType();

            public int hashCode() => map.GetHashCode();

            public bool isEmpty() => map.Count == 0;

            public Set<T1> keySet()
            {
                var set = new Set<T1>();
                foreach (var key in map.Keys)
                {
                    set.add(key);
                }

                return set;
            }

            public T2 put(T1 key, T2 value) => map[key] = value;

            public void putAll(Map<T1, T2> fromMap)
            {
                foreach (var pair in fromMap)
                {
                    map[pair.Key] = pair.Value;
                }
            }

            private void AddItems(IEnumerable<T2> items)
            {
                ValidateGenericTypeParameters();

                foreach (object row in items)
                {
                    SObject sobj = (SObject)row;
                    object key = sobj.Id;
                    map[(T1)key] = (T2)row;
                }
            }

            public void putAll(T2[] sobjectArray) => AddItems(sobjectArray);

            public void putAll(global::Apex.System.List<T2> entries) => AddItems(entries);

            public T2 remove(T1 key)
            {
                var value = map[key];
                map.Remove(key);
                return value;
            }

            public int size() => map.Count;

            public global::Apex.System.List<T2> values()
            {
                var result = new global::Apex.System.List<T2>(map.Count);
                foreach (var item in map.Values)
                {
                    result.add(item);
                }

                return result;
            }

            // interoperability

            public IEnumerator<KeyValuePair<T1, T2>> GetEnumerator() => map.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => map.GetEnumerator();
        }

        // Implementation

        public dynamic Constructor() => new MapInstance<T1Outer, T2Outer>();

        public dynamic Constructor(Map<T1Outer, T2Outer> mapToCopy) => new MapInstance<T1Outer, T2Outer>(mapToCopy);

        public dynamic Constructor(IEnumerable<KeyValuePair<T1Outer, T2Outer>> dictionary) => new MapInstance<T1Outer, T2Outer>(dictionary);

        public dynamic Constructor(global::Apex.System.List<T2Outer> recordList) => new MapInstance<T1Outer, T2Outer>(recordList);

        public dynamic Constructor(SoqlQuery<T2Outer> soqlQuery) => new MapInstance<T1Outer, T2Outer>(soqlQuery);
    }
}

using System;
using ApexSharpApi;
using ApexSharpApi.ApexApi;

namespace Apex.System
{
    public class Map<T, K> : global::System.Collections.Generic.SortedDictionary<T, K>
    {
        public Map()
        {
        }

        public Map(SoqlQuery<K> soqlQuery)
        {
            // make sure that Map<T, K> is Map<ID, SObject>
            if (!typeof(SObject).IsAssignableFrom(typeof(K)) ||
                !typeof(ID).IsAssignableFrom(typeof(T)))
            {
                throw new NotSupportedException("Only Map<ID, SObject> can be initialized via SOQL query data.");
            }

            foreach (object row in soqlQuery.QueryResult.Value)
            {
                var sobj = (SObject)row;
                object key = sobj.Id;
                this[(T)key] = (K)row;
            }
        }

        public Map(List<K> objectList)
        {

        }

        public Map(List<object> param1)
        {
            throw new global::System.NotImplementedException("Map");
        }

        public Map(Map<object, object> param1)
        {
            throw new global::System.NotImplementedException("Map");
        }

        public void clear()
        {
            throw new global::System.NotImplementedException("Map.Clear");
        }

        public Map<String, String> clone()
        {
            throw new global::System.NotImplementedException("Map.Clone");
        }

        public bool containsKey(object key)
        {
            throw new global::System.NotImplementedException("Map.ContainsKey");
        }

        public Map<String, String> deepClone()
        {
            throw new global::System.NotImplementedException("Map.DeepClone");
        }

        public bool equals(object obj)
        {
            throw new global::System.NotImplementedException("Map.Equals");
        }

        public K get(T key)
        {
            return default(K);
        }

        //public Schema.SObjectType GetSObjectType() { throw new global::System.NotImplementedException("Map.GetSObjectType"); }
        public int hashCode()
        {
            throw new global::System.NotImplementedException("Map.HashCode");
        }

        public bool isEmpty()
        {
            throw new global::System.NotImplementedException("Map.IsEmpty");
        }

        public Set<T> keySet()
        {
            return new Set<T>();
        }

        public string put(object key, object value)
        {
            //throw new global::System.NotImplementedException("Map.Put");
            return "";
        }

        public void putAll(List<T> entries)
        {
            throw new global::System.NotImplementedException("Map.PutAll");
        }

        public void putAll(Map<T, K> entries)
        {
            throw new global::System.NotImplementedException("Map.PutAll");
        }

        public string remove(object key)
        {
            throw new global::System.NotImplementedException("Map.Remove");
        }

        public int size()
        {
            throw new global::System.NotImplementedException("Map.Size");
        }

        public List<string> values()
        {
            throw new global::System.NotImplementedException("Map.Values");
        }
    }
}
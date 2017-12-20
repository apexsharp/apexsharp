using Apex.Schema;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ApexSharpApi;

namespace Apex.System
{
    public class List<T> : IEnumerable<T>
    {
        private global::System.Collections.Generic.List<T> list;
        public List()
        {
            list = new global::System.Collections.Generic.List<T>();
        }

        public List(int size)
        {
            list = new global::System.Collections.Generic.List<T>(size);
        }

        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public void add(T item)
        {
            list.Add(item);
        }

        public IEnumerator<T> getEnumerator()
        {
            return list.GetEnumerator();
        }

        public void addAll(List<T> elements)
        {
            foreach (var element in elements)
            {
                list.Add(element);
            }
        }

        public int size()
        {
            return list.Count;
        }

        public void add(int index, object element)
        {
            throw new global::System.NotImplementedException("List.Add");
        }

        public void addAll(Set<T> elements)
        {
            throw new global::System.NotImplementedException("List.AddAll");
        }

        public void clear()
        {
            list.Clear();
        }

        public List<string> clone()
        {
            throw new global::System.NotImplementedException("List.Clone");
        }

        public List<string> deepClone()
        {
            throw new global::System.NotImplementedException("List.DeepClone");
        }

        public List<string> deepClone(bool preserveId)
        {
            throw new global::System.NotImplementedException("List.DeepClone");
        }

        public List<string> deepClone(bool preserveId, bool preserveReadOnlyTimestamps)
        {
            throw new global::System.NotImplementedException("List.DeepClone");
        }

        public List<string> deepClone(bool preserveId, bool preserveReadOnlyTimestamps, bool preserveAutoNumbers)
        {
            throw new global::System.NotImplementedException("List.DeepClone");
        }

        public bool equals(object obj)
        {
            throw new global::System.NotImplementedException("List.Equals");
        }

        public T get(int index)
        {
            return list[index];
        }

        public SObjectType getSObjectType()
        {
            throw new global::System.NotImplementedException("List.GetSObjectType");
        }

        public int hashCode()
        {
            throw new global::System.NotImplementedException("List.HashCode");
        }

        public bool isEmpty()
        {
            return list.Count == 0;
        }

        public Iterable iterator()
        {
            throw new global::System.NotImplementedException("List.Iterator");
        }

        public T remove(int index)
        {
            var value = list[index];
            list.RemoveAt(index);
            return value;
        }

        public void set(int index, object value)
        {
            throw new global::System.NotImplementedException("List.Set");
        }

        public void sort()
        {
            list.Sort();
        }

        public static implicit operator List<T>(SoqlQuery<T> query)
        {
            var result = new List<T>();
            foreach (var row in query.QueryResult.Value)
            {
                result.add(row);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
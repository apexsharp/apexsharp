using System.Linq;
using Apex.ApexSharp.Implementation;
using Apex.Schema;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(List<>))]
    public class ListImplementation<TOuter>
    {
        // Self

        public class ListInstance<T> : global::System.Collections.Generic.IEnumerable<T>
        {
            private global::System.Collections.Generic.List<T> list;

            public ListInstance() => list = new global::System.Collections.Generic.List<T>();

            public ListInstance(int size) => list = new global::System.Collections.Generic.List<T>(size);

            public ListInstance(List<T> listToCopy) => list = listToCopy.ToList();

            public ListInstance(Set<T> setToCopy) => list = setToCopy.ToList();

            public ListInstance(global::System.Collections.Generic.IEnumerable<T> enumerable) => list = enumerable.ToList();

            public void add(T item) => list.Add(item);

            public void add(int index, T element) => list.Insert(index, element);

            public void addAll(List<T> elements) => list.AddRange(elements);

            public void addAll(Set<T> elements) => throw new Exception();

            public void clear() => list.Clear();

            public List<T> clone() => new List<T>(new ListInstance<T>(this.AsEnumerable()));

            public List<T> deepClone() => clone();

            public List<T> deepClone(bool preserveId) => deepClone();

            public List<T> deepClone(bool preserveId, bool preserveReadOnlyTimestamps) => deepClone();

            public List<T> deepClone(bool preserveId, bool preserveReadOnlyTimestamps, bool preserveAutoNumbers) => deepClone();

            public global::System.Collections.Generic.IEnumerator<T> GetEnumerator() => list.GetEnumerator();

            public int size() => list.Count;

            public T get(int index) => list[index];

            public bool equals(object obj)
            {
                var other = obj as List<T>;
                if (other == null)
                {
                    return false;
                }

                if (other.size() != list.Count())
                {
                    return false;
                }

                foreach (var item in list.Zip(other, (t, o) => new { t, o }))
                {
                    if (!Equals(item.t, item.o))
                    {
                        return false;
                    }
                }

                return true;
            }

            public int hashCode() => list.GetHashCode();

            public bool isEmpty() => list.Count == 0;

            public T remove(int index)
            {
                var value = list[index];
                list.RemoveAt(index);
                return value;
            }

            public void set(int index, T value) => list[index] = value;

            public void sort() => list.Sort();

            public SObjectType getSObjectType() =>
                throw new global::System.NotImplementedException("List.getSObjectType()");

            public Iterable iterator() =>
                throw new global::System.NotImplementedException("List.Iterator");

            global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
        }

        // Implementation

        public dynamic Constructor() => new ListInstance<TOuter>();

        public dynamic Constructor(int size) => new ListInstance<TOuter>(size);

        public dynamic Constructor(List<TOuter> listToCopy) => new ListInstance<TOuter>(listToCopy);

        public dynamic Constructor(Set<TOuter> setToCopy) => new ListInstance<TOuter>(setToCopy);
    }
}

using System.Linq;
using Apex.ApexSharp.Implementation;
using Apex.Schema;
using Apex.System;
using IEnumerable = System.Collections.IEnumerable;
using IEnumerator = System.Collections.IEnumerator;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Set<>))]
    public class SetImplementation<TOuter>
    {
        // Self

        public class SetInstance<T> : global::System.Collections.Generic.IEnumerable<T>
        {
            private dynamic NotImplemented { get; } = new StubImplementation(typeof(Set<T>));

            private global::System.Collections.Generic.HashSet<T> set;

            public SetInstance() => set = new global::System.Collections.Generic.HashSet<T>();

            public SetInstance(List<T> listToCopy) => set = new global::System.Collections.Generic.HashSet<T>(listToCopy.AsEnumerable());

            public SetInstance(Set<T> setToCopy) => set = new global::System.Collections.Generic.HashSet<T>(setToCopy.AsEnumerable());

            public SetInstance(global::System.Collections.Generic.IEnumerable<T> enumerable) => set = new global::System.Collections.Generic.HashSet<T>(enumerable);

            public bool add(T item) => set.Add(item);

            public bool addAll(List<T> elements)
            {
                var result = false;
                foreach (var element in elements)
                {
                    result |= set.Add(element);
                }

                return result;
            }

            public bool addAll(Set<T> elements)
            {
                var result = false;
                foreach (var element in elements)
                {
                    result |= set.Add(element);
                }

                return result;
            }

            public void clear() => set.Clear();

            public Set<T> clone() => new Set<T>(new SetInstance<T>(this.AsEnumerable()));

            public bool contains(T setElement) => set.Contains(setElement);

            public bool containsAll(List<T> listToCompare) => listToCompare.All(item => set.Contains(item));

            public bool containsAll(Set<T> setToCompare) => setToCompare.All(item => set.Contains(item));

            public int size() => set.Count;

            public bool equals(object obj)
            {
                var other = obj as Set<T>;
                if (other == null)
                {
                    return false;
                }

                return equals(other);
            }

            public bool equals(Set<T> other)
            {
                if (other.size() != set.Count())
                {
                    return false;
                }

                foreach (var item in other)
                {
                    if (!set.Contains(item))
                    {
                        return false;
                    }
                }

                return true;
            }

            public int hashCode() => set.GetHashCode();

            public bool isEmpty() => set.Count == 0;

            public bool remove(T setElement) => set.Remove(setElement);

            public bool removeAll(List<T> listOfElementsToRemove)
            {
                var result = false;
                foreach (var item in listOfElementsToRemove)
                {
                    result |= set.Remove(item);
                }

                return result;
            }

            public bool removeAll(Set<T> setOfElementsToRemove)
            {
                var result = false;
                foreach (var item in setOfElementsToRemove)
                {
                    result |= set.Remove(item);
                }

                return result;
            }

            public bool retainAll(List<T> listOfElementsToRetain) => retainAll(new Set<T>(listOfElementsToRetain));

            public bool retainAll(Set<T> setOfElementsToRetain)
            {
                var result = false;
                foreach (var item in set.ToArray())
                {
                    if (!setOfElementsToRetain.contains(item))
                    {
                        result |= set.Remove(item);
                    }
                }

                return result;
            }

            public Iterable iterator() => NotImplemented.iterator();

            public global::System.Collections.Generic.IEnumerator<T> GetEnumerator() => set.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        // Implementation

        public dynamic Constructor() => new SetInstance<TOuter>();

        public dynamic Constructor(List<TOuter> listToCopy) => new SetInstance<TOuter>(listToCopy);

        public dynamic Constructor(Set<TOuter> setToCopy) => new SetInstance<TOuter>(setToCopy);
    }
}

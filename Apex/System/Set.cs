namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_set.htm#apex_methods_system_set
    /// </summary>
    public class Set<T> : global::System.Collections.Generic.IEnumerable<T>
    {
        // infrastructure
        public Set(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Set<T>));
            }
        }

        // API
        public Set()
        {
            Self = Implementation.Constructor();
        }

        ////public Set(object param1)
        ////{
        ////    Implementation.Constructor(param1);
        ////}

        public Set(Set<T> setToCopy)
        {
            Self = Implementation.Constructor(setToCopy);
        }

        public Set(List<T> listToCopy)
        {
            Self = Implementation.Constructor(listToCopy);
        }

        public bool add(T setElement)
        {
            return Self.add(setElement);
        }

        public bool addAll(List<T> fromList)
        {
            return Self.addAll(fromList);
        }

        public bool addAll(Set<T> fromSet)
        {
            return Self.addAll(fromSet);
        }

        public void clear()
        {
            Self.clear();
        }

        public Set<T> clone()
        {
            return Self.clone();
        }

        public bool contains(T setElement)
        {
            return Self.contains(setElement);
        }

        public bool containsAll(List<T> listToCompare)
        {
            return Self.containsAll(listToCompare);
        }

        public bool containsAll(Set<T> setToCompare)
        {
            return Self.containsAll(setToCompare);
        }

        public bool equals(Set<T> set2)
        {
            return Self.equals(set2);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public bool isEmpty()
        {
            return Self.isEmpty();
        }

        public bool remove(T setElement)
        {
            return Self.remove(setElement);
        }

        public bool removeAll(List<T> listOfElementsToRemove)
        {
            return Self.removeAll(listOfElementsToRemove);
        }

        public bool removeAll(Set<T> setOfElementsToRemove)
        {
            return Self.removeAll(setOfElementsToRemove);
        }

        public bool retainAll(List<T> listOfElementsToRetain)
        {
            return Self.retainAll(listOfElementsToRetain);
        }

        public bool retainAll(Set<T> setOfElementsToRetain)
        {
            return Self.retainAll(setOfElementsToRetain);
        }

        public int size()
        {
            return Self.size();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public Iterator iterator()
        {
            return Self.iterator();
        }

        // initializer support

        global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<T>.GetEnumerator() =>
            Self.GetEnumerator();

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() =>
            Self.GetEnumerator();

        public void Add(T item) => add(item);
    }
}

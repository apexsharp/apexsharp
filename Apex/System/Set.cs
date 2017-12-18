namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_set.htm#apex_methods_system_set
    /// </summary>
    public class Set<T>
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

        public bool add(object setElement)
        {
            return Self.add(setElement);
        }

        public bool addAll(List<object> fromList)
        {
            return Self.addAll(fromList);
        }

        public bool addAll(Set<object> fromSet)
        {
            return Self.addAll(fromSet);
        }

        public void clear()
        {
            Self.clear();
        }

        public Set<object> clone()
        {
            return Self.clone();
        }

        public bool contains(object setElement)
        {
            return Self.contains(setElement);
        }

        public bool containsAll(List<object> listToCompare)
        {
            return Self.containsAll(listToCompare);
        }

        public bool containsAll(Set<object> setToCompare)
        {
            return Self.containsAll(setToCompare);
        }

        public bool equals(Set<object> set2)
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

        public bool remove(object setElement)
        {
            return Self.remove(setElement);
        }

        public bool removeAll(List<object> listOfElementsToRemove)
        {
            return Self.removeAll(listOfElementsToRemove);
        }

        public bool removeAll(Set<object> setOfElementsToRemove)
        {
            return Self.removeAll(setOfElementsToRemove);
        }

        public bool retainAll(List<object> listOfElementsToRetain)
        {
            return Self.retainAll(listOfElementsToRetain);
        }

        public bool retainAll(Set<object> setOfElementsToRetain)
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
    }
}

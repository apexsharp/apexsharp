namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_list.htm#apex_methods_system_list
    /// </summary>
    public class List<T> : global::System.Collections.Generic.IEnumerable<T>
    {
        // infrastructure
        public List(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(List<T>));
            }
        }

        // API
        public List()
        {
            Self = Implementation.Constructor();
        }

        public List(int param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public List(List<T> listToCopy)
        {
            Self = Implementation.Constructor(listToCopy);
        }

        public List(Set<T> setToCopy)
        {
            Self = Implementation.Constructor(setToCopy);
        }

        public void add(T listElement)
        {
            Self.add(listElement);
        }

        public void add(int index, T listElement)
        {
            Self.add(index, listElement);
        }

        public void addAll(List<T> fromList)
        {
            Self.addAll(fromList);
        }

        public void addAll(Set<T> fromSet)
        {
            Self.addAll(fromSet);
        }

        public void clear()
        {
            Self.clear();
        }

        public List<T> clone()
        {
            return Self.clone();
        }

        public List<T> deepClone(bool preserveId, bool preserveReadonlyTimestamps, bool preserveAutonumber)
        {
            return Self.deepClone(preserveId, preserveReadonlyTimestamps, preserveAutonumber);
        }

        public bool equals(List<T> list2)
        {
            return Self.equals(list2);
        }

        public T get(int index)
        {
            return Self.get(index);
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

        public Iterator iterator()
        {
            return Self.iterator();
        }

        public T remove(int index)
        {
            return Self.remove(index);
        }

        public void set(int index, T listElement)
        {
            Self.set(index, listElement);
        }

        public int size()
        {
            return Self.size();
        }

        public void sort()
        {
            Self.sort();
        }

        public List<T> deepClone(bool preserveId, bool preserveReadOnlyTimestamps)
        {
            return Self.deepClone(preserveId, preserveReadOnlyTimestamps);
        }

        public List<T> deepClone(bool preserveId)
        {
            return Self.deepClone(preserveId);
        }

        public List<T> deepClone()
        {
            return Self.deepClone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        // initializer support

        global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<T>.GetEnumerator() =>
            Self.GetEnumerator();

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() =>
            Self.GetEnumerator();

        public void Add(T item) => add(item);

        public T this[int index] => get(index);

        public static implicit operator List<T>(SoqlQuery<T> query)
        {
            var result = new List<T>();
            foreach (var row in query.QueryResult.Value)
            {
                result.add(row);
            }

            return result;
        }
    }
}

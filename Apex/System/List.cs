namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_list.htm#apex_methods_system_list
    /// </summary>
    public class List<T>
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

        public List(List<T> listToCopy)
        {
            Self = Implementation.Constructor(listToCopy);
        }

        public List(Set<T> setToCopy)
        {
            Self = Implementation.Constructor(setToCopy);
        }

        public void add(object listElement)
        {
            Self.add(listElement);
        }

        public void add(int index, object listElement)
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

        public List<object> clone()
        {
            return Self.clone();
        }

        public List<object> deepClone(bool preserveId, bool preserveReadonlyTimestamps, bool preserveAutonumber)
        {
            return Self.deepClone(preserveId, preserveReadonlyTimestamps, preserveAutonumber);
        }

        public bool equals(List<T> list2)
        {
            return Self.equals(list2);
        }

        public object get(int index)
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

        public object remove(int index)
        {
            return Self.remove(index);
        }

        public void set(int index, object listElement)
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

        public List(int param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public List<object> deepClone(bool preserveId, bool preserveReadOnlyTimestamps)
        {
            return Self.deepClone(preserveId, preserveReadOnlyTimestamps);
        }

        public List<object> deepClone(bool preserveId)
        {
            return Self.deepClone(preserveId);
        }

        public List<object> deepClone()
        {
            return Self.deepClone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }
    }
}

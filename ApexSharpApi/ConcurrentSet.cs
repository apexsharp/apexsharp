using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ApexSharpApi
{
    public class ConcurrentSet<T> : IEnumerable<T>
    {
        public ConcurrentSet()
        {
            Values = new ConcurrentDictionary<T, T>();
        }

        public ConcurrentSet(IEqualityComparer<T> comparer)
        {
            Values = new ConcurrentDictionary<T, T>(comparer);
        }

        private ConcurrentDictionary<T, T> Values { get; set; }

        public bool Add(T value) => Values.TryAdd(value, value);

        public void UnionWith(IEnumerable<T> values)
        {
            foreach (var v in values)
            {
                Values[v] = v;
            }
        }

        public bool Contains(T value) => Values.ContainsKey(value);

        public void Clear() => Values.Clear();

        public IEnumerator<T> GetEnumerator() => Values.Keys.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Values.Keys.GetEnumerator();
    }
}

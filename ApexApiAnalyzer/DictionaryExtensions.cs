using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexApiAnalyzer
{
    public static class DictionaryExtensions
    {
        public static V GetOrAdd<K, V>(this IDictionary<K, V> self, K key, Func<K, V> factory)
        {
            if (self.TryGetValue(key, out var value))
            {
                return value;
            }

            var created = factory(key);
            self[key] = created;
            return created;
        }

        public static V GetOrDefault<K, V>(this IDictionary<K, V> self, K key, V defaultValue = default(V))
        {
            if (self.TryGetValue(key, out var value))
            {
                return value;
            }

            return defaultValue;
        }
    }
}

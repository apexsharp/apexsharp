using Apex.System;
using NUnit.Framework;
using NotImplementedException = System.NotImplementedException;

namespace ApexTest.System
{
    [TestFixture]
    public class MapTests
    {
        [Test]
        public void NewMapHasZeroSizeAndIsEmpty()
        {
            Assert.DoesNotThrow(() =>
            {
                var map = new Map<int, string>();
                Assert.AreEqual(0, map.size());
                Assert.IsTrue(map.isEmpty());

                var hashCode = map.hashCode();
            });
        }

        [Test]
        public void PutPutAllGetContainsKeyValuesAndClearMethodsAndTheIndexerWorkAsExpected()
        {
            Assert.DoesNotThrow(() =>
            {
                var map = new Map<int, string> { { 1, "One" }, { 2, "Two" } };
                Assert.AreEqual(2, map.size());

                var newMap = new Map<int, string>(map);
                Assert.AreEqual(2, newMap.size());

                map.put(4, "Four");
                map.put(5, "Five");
                map.put(6, "Six");
                Assert.AreEqual(5, map.size());

                newMap.putAll(map);
                Assert.AreEqual(5, newMap.size());

                var five = map.get(5);
                Assert.AreEqual("Five", five);

                var six = map[6];
                Assert.AreEqual("Six", six);

                Assert.True(map.containsKey(6));
                Assert.False(map.containsKey(7));

                var values = map.values();
                Assert.AreEqual(5, values.size());

                map.clear();
                Assert.Zero(map.size());
                Assert.NotZero(newMap.size());
            });
        }

        [Test]
        public void CloneEqualsAndDeepCloneMethodsAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var cloneMethods = new global::System.Func<Map<string, string>, Map<string, string>>[]
                {
                    m => m.clone(), m => m.deepClone(),
                };

                foreach (var cloneMethod in cloneMethods)
                {
                    var map = new Map<string, string> { { "Hello", "World" } };
                    Assert.AreEqual(1, map.size());

                    var mapClone = cloneMethod(map);
                    Assert.NotNull(mapClone);
                    Assert.AreEqual(1, mapClone.size());
                    Assert.IsTrue(mapClone.equals(map));

                    mapClone.put("Again", "And Again");
                    Assert.AreEqual(2, mapClone.size());

                    Assert.AreEqual(1, map.size());
                    Assert.IsFalse(mapClone.equals(map));
                }
            });
        }

        [Test]
        public void OtherMethodsAreNotImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var map = new Map<int, object>();

                Assert.Throws<NotImplementedException>(() => map.getSObjectType());
                Assert.Throws<NotImplementedException>(() => map.keySet());
            });
        }
    }
}

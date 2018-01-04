using System.Linq;
using Apex.System;
using ApexSharpApi;
using NUnit.Framework;
using NotImplementedException = System.NotImplementedException;
using NotSupportedException = System.NotSupportedException;

namespace ApexTest.System
{
    using LazyOfListOfSample = global::System.Lazy<global::System.Collections.Generic.List<MapTests.SampleSObject>>;
    using ListOfSample = global::System.Collections.Generic.List<MapTests.SampleSObject>;

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

        public class SampleSObject : SObject
        {
            public string Name { get; set; }
        }

        [Test]
        public void MapCanBeInitializedWithListOfSObjects()
        {
            Assert.DoesNotThrow(() =>
            {
                var map = new Map<ID, SampleSObject>(new List<SampleSObject>
                {
                    new SampleSObject { Id = "111", Name = "One" },
                    new SampleSObject { Id = "222", Name = "Two" },
                });

                var item111 = map.get("111");
                Assert.NotNull(item111);
                Assert.AreEqual("One", item111.Name);

                var item222 = map.get("222");
                Assert.NotNull(item222);
                Assert.AreEqual("Two", item222.Name);
            });
        }

        [Test]
        public void PutAllMethodsAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                void validateMap(Map<ID, SampleSObject> map)
                {
                    Assert.NotNull(map);
                    Assert.AreEqual(2, map.size());

                    var item111 = map.get("111");
                    Assert.NotNull(item111);
                    Assert.AreEqual("One", item111.Name);

                    var item222 = map.get("222");
                    Assert.NotNull(item222);
                    Assert.AreEqual("Two", item222.Name);
                };

                var list = new List<SampleSObject>
                {
                    new SampleSObject { Id = "111", Name = "One" },
                    new SampleSObject { Id = "222", Name = "Two" },
                };

                var array = list.ToArray();
                var srcMap = new Map<ID, SampleSObject>(list);

                var map1 = new Map<ID, SampleSObject>();
                map1.putAll(srcMap);
                validateMap(map1);

                var map2 = new Map<ID, SampleSObject>();
                map2.putAll(list);
                validateMap(map2);

                var map3 = new Map<ID, SampleSObject>();
                map3.putAll(array);
                validateMap(map3);
            });
        }

        private ListOfSample GetSampleObjects() => new ListOfSample
        {
            new SampleSObject { Id = "123", Name = "OneTwoThree" },
            new SampleSObject { Id = "321", Name = "ThreeTwoOne" },
        };

        [Test]
        public void MapCanBeInitializedWithSoqlQueryResults()
        {
            Assert.DoesNotThrow(() =>
            {
                var lazyData = new LazyOfListOfSample(GetSampleObjects);
                var query = new SoqlQuery<SampleSObject>(lazyData, string.Empty);
                var map = new Map<ID, SampleSObject>(query);

                var item123 = map.get("123");
                Assert.NotNull(item123);
                Assert.AreEqual("OneTwoThree", item123.Name);

                var item321 = map.get("321");
                Assert.NotNull(item321);
                Assert.AreEqual("ThreeTwoOne", item321.Name);
            });
        }

        [Test]
        public void IncompatibleMapTypeIsReported()
        {
            var lazyData = new LazyOfListOfSample(GetSampleObjects);
            var query = new SoqlQuery<SampleSObject>(lazyData, string.Empty);

            Assert.Throws<NotSupportedException>(() =>
            {
                new Map<int, SampleSObject>(query);
            });
        }

        [Test]
        public void KeySetMethodIsImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var lazyData = new LazyOfListOfSample(GetSampleObjects);
                var query = new SoqlQuery<SampleSObject>(lazyData, string.Empty);
                var map = new Map<ID, SampleSObject>(query);

                var keySet = map.keySet();
                Assert.NotNull(keySet);
                Assert.AreEqual(2, keySet.size());

                Assert.IsTrue(keySet.contains("123"));
                Assert.IsTrue(keySet.contains("321"));
                Assert.IsFalse(keySet.contains("111"));
            });
        }

        [Test]
        public void OtherMethodsAreNotImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var map = new Map<int, object>();

                Assert.Throws<NotImplementedException>(() => map.getSObjectType());
            });
        }
    }
}

using Apex.System;
using NUnit.Framework;
using NotImplementedException = System.NotImplementedException;

namespace ApexTest.System
{
    [TestFixture]
    public class ListTests
    {
        [Test]
        public void NewListHasZeroSizeAndIsEmpty()
        {
            Assert.DoesNotThrow(() =>
            {
                var list = new List<int>();
                Assert.AreEqual(0, list.size());
                Assert.IsTrue(list.isEmpty());

                var hashCode = list.hashCode();
            });
        }

        [Test]
        public void AddAndAddAllMethodsWorkAsExpected()
        {
            Assert.DoesNotThrow(() =>
            {
                var list = new List<int> { 1, 2, 3 };
                Assert.AreEqual(3, list.size());

                var newList = new List<int>(list);
                Assert.AreEqual(3, newList.size());

                list.add(4);
                list.add(5);
                list.add(6);
                Assert.AreEqual(6, list.size());

                newList.addAll(list);
                Assert.AreEqual(9, newList.size());
            });
        }

        [Test]
        public void CloneEqualsAndDeepCloneMethodsAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var cloneMethods = new global::System.Func<List<string>, List<string>>[]
                {
                    l => l.clone(), l => l.deepClone(),
                    l => l.deepClone(true), l => l.deepClone(false),
                    l => l.deepClone(true, true), l => l.deepClone(true, false),
                    l => l.deepClone(false, true), l => l.deepClone(false, false),
                    l => l.deepClone(true, true, true), l => l.deepClone(true, true, false),
                    l => l.deepClone(true, false, true), l => l.deepClone(true, false, false),
                    l => l.deepClone(false, true, true), l => l.deepClone(false, true, false),
                    l => l.deepClone(false, false, true), l => l.deepClone(false, false, false),
                };

                foreach (var cloneMethod in cloneMethods)
                {
                    var list = new List<string> { "Hello", "World" };
                    Assert.AreEqual(2, list.size());

                    var listClone = cloneMethod(list);
                    Assert.NotNull(listClone);
                    Assert.AreEqual(2, listClone.size());
                    Assert.IsTrue(listClone.equals(list));

                    listClone.add("Again");
                    listClone.add("And Again");
                    Assert.AreEqual(4, listClone.size());

                    Assert.AreEqual(2, list.size());
                    Assert.IsFalse(listClone.equals(list));
                }
            });
        }

        [Test]
        public void GetSetAndIndexerAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var list = new List<int> { 1, 2, 3 };
                Assert.AreEqual(3, list.size());

                Assert.AreEqual(1, list[0]);
                Assert.AreEqual(2, list[1]);
                Assert.AreEqual(3, list[2]);

                Assert.AreEqual(1, list.get(0));
                Assert.AreEqual(2, list.get(1));
                Assert.AreEqual(3, list.get(2));

                list.set(2, 1);
                list.set(1, 2);
                list.set(0, 3);

                Assert.AreEqual(3, list.get(0));
                Assert.AreEqual(2, list.get(1));
                Assert.AreEqual(1, list.get(2));
            });
        }

        [Test]
        public void RemoveAndSetAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var list = new List<string> { "That's", "All", "Folks" };
                Assert.AreEqual(3, list.size());

                list.set(1, "Not All");
                list.set(2, "Dudes");

                Assert.AreEqual("Not All", list.remove(1));
                Assert.AreEqual("Dudes", list.remove(1));
                Assert.AreEqual("That's", list.remove(0));
            });
        }

        [Test]
        public void OtherMethodsAreNotImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var list = new List<object>(1);

                Assert.Throws<NotImplementedException>(() => list.getSObjectType());
                Assert.Throws<NotImplementedException>(() => list.iterator());
            });
        }
    }
}

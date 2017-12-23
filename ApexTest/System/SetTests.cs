using Apex.System;
using NUnit.Framework;
using NotImplementedException = System.NotImplementedException;

namespace ApexTest.System
{
    [TestFixture]
    public class SetTests
    {
        [Test]
        public void NewSetHasZeroSizeAndIsEmpty()
        {
            Assert.DoesNotThrow(() =>
            {
                var set = new Set<int>();
                Assert.AreEqual(0, set.size());
                Assert.IsTrue(set.isEmpty());

                var hashCode = set.hashCode();
            });
        }

        [Test]
        public void AddAndAddAllMethodsWorkAsExpected()
        {
            Assert.DoesNotThrow(() =>
            {
                var set = new Set<int> { 1, 2, 3 };
                Assert.AreEqual(3, set.size());

                var newSet = new Set<int>(set);
                Assert.AreEqual(3, newSet.size());

                Assert.IsTrue(set.add(4));
                Assert.IsTrue(set.add(5));
                Assert.IsFalse(set.add(5));
                Assert.IsTrue(set.add(6));
                Assert.AreEqual(6, set.size());

                newSet.addAll(set);
                Assert.AreEqual(6, newSet.size());
            });
        }

        [Test]
        public void CloneAndEqualsMethodsAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var set = new Set<string> { "Hello", "World" };
                Assert.AreEqual(2, set.size());

                var setClone = set.clone();
                Assert.NotNull(setClone);
                Assert.AreEqual(2, setClone.size());
                Assert.IsTrue(setClone.equals(set));

                Assert.IsTrue(setClone.add("Again"));
                Assert.IsFalse(setClone.add("Again"));
                Assert.IsTrue(setClone.add("And Again"));
                Assert.AreEqual(4, setClone.size());

                Assert.AreEqual(2, set.size());
                Assert.IsFalse(setClone.equals(set));
            });
        }

        [Test]
        public void RemoveAndRemoveAllAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var set = new Set<string> { "That's", "All", "Folks" };
                Assert.AreEqual(3, set.size());

                Assert.IsFalse(set.remove("Not All"));
                var list = new List<string> { "All", "That", "Jazz" };
                Assert.True(set.removeAll(list));

                Assert.IsTrue(set.contains("That's"));
                Assert.IsFalse(set.contains("All"));
                Assert.IsTrue(set.contains("Folks"));
            });
        }

        [Test]
        public void RetainAllAreImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var set = new Set<string> { "That's", "All", "Folks" };
                Assert.AreEqual(3, set.size());

                var list = new List<string> { "All", "That", "Folks" };
                Assert.True(set.retainAll(list));

                Assert.IsFalse(set.contains("That's"));
                Assert.IsTrue(set.contains("All"));
                Assert.IsTrue(set.contains("Folks"));
            });
        }

        [Test]
        public void OtherMethodsAreNotImplemented()
        {
            Assert.DoesNotThrow(() =>
            {
                var set = new Set<object>();

                Assert.Throws<NotImplementedException>(() => set.iterator());
            });
        }
    }
}

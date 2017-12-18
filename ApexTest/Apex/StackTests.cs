using Apex.Apex;
using NUnit.Framework;

namespace ApexTest.Apex
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void NewStackIsEmpty()
        {
            Assert.DoesNotThrow(() =>
            {
                var stack = new Stack<int>();
                Assert.True(stack.empty());
            });
        }

        [Test]
        public void PoppingAndPeekingFromAnEmptyStackThrowsException()
        {
            Assert.Throws<EmptyStackException>(() => new Stack<int>().pop());
            Assert.Throws<EmptyStackException>(() => new Stack<string>().peek());
        }

        [Test]
        public void PushingPeekingAndPoppingIntegerValues()
        {
            Assert.DoesNotThrow(() =>
            {
                var stack = new Stack<int>();
                stack.push(1);
                stack.push(2);
                stack.push(3);

                var pop = stack.pop();
                Assert.AreEqual(3, pop);

                var peek = stack.peek();
                Assert.AreEqual(2, peek);

                Assert.AreEqual(2, stack.pop());
                Assert.AreEqual(1, stack.pop());
                Assert.IsTrue(stack.empty());
                Assert.Throws<EmptyStackException>(() => stack.pop());
            });
        }

        [Test]
        public void CloningAStackCreatesAnIndependentCopy()
        {
            Assert.DoesNotThrow(() =>
            {
                var stack = new Stack<string>();
                stack.push("Hello");
                stack.push("Cruel");
                stack.push("World");

                var clone = stack.clone() as Stack<string>;
                Assert.NotNull(clone);

                // validate the clone contents
                var pop = clone.pop();
                Assert.AreEqual("World", pop);

                var peek = clone.peek();
                Assert.AreEqual("Cruel", peek);

                Assert.AreEqual("Cruel", clone.pop());
                Assert.AreEqual("Hello", clone.pop());
                Assert.IsTrue(clone.empty());
                Assert.Throws<EmptyStackException>(() => clone.pop());

                // the original stack contents should remain unchanged
                pop = stack.pop();
                Assert.AreEqual("World", pop);

                peek = stack.peek();
                Assert.AreEqual("Cruel", peek);

                Assert.AreEqual("Cruel", stack.pop());
                Assert.AreEqual("Hello", stack.pop());
                Assert.IsTrue(stack.empty());
                Assert.Throws<EmptyStackException>(() => stack.pop());
            });
        }
    }
}

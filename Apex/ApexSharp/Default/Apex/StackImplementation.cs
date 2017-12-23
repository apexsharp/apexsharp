using System.Linq;
using Apex.Apex;
using Apex.ApexSharp.Implementation;

namespace Apex.ApexSharp.Default.Apex
{
    [Implements(typeof(Stack<>))]
    public class StackImplementation<TOuter>
    {
        // Self

        public class StackInstance<T>
        {
            readonly global::System.Collections.Generic.Stack<T> _Stack;

            public StackInstance()
            {
                _Stack = new global::System.Collections.Generic.Stack<T>();
            }

            private StackInstance(StackInstance<T> other)
            {
                // copy the contents of the stack
                _Stack = new global::System.Collections.Generic.Stack<T>(other._Stack.Reverse());
            }

            public object clone() => new Stack<T>(new StackInstance<T>(this));

            public bool empty() => _Stack.Count == 0;

            public T peek()
            {
                if (_Stack.Count == 0)
                {
                    throw new EmptyStackException();
                }

                return _Stack.Peek();
            }

            public T pop()
            {
                if (_Stack.Count == 0)
                {
                    throw new EmptyStackException();
                }

                return _Stack.Pop();
            }

            public void push(T item) => _Stack.Push(item);
        }

        // Implementation

        public dynamic Constructor()
        {
            return new StackInstance<TOuter>();
        }
    }
}

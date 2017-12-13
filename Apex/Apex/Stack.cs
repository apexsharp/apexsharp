namespace Apex.Apex
{
    public class Stack<T>
    {
        readonly global::System.Collections.Generic.Stack<T> _Stack;

        public Stack()
        {
            _Stack = new global::System.Collections.Generic.Stack<T>();
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("Stack.Clone");
        }

        public bool empty()
        {
            _Stack.Clear();
            return true;
        }

        public T peek()
        {
            return _Stack.Peek();
        }

        public T pop()
        {
            if (_Stack.Count == 0) throw new EmptyStackException();
            else
            {
                return _Stack.Pop();
            }
        }

        public void push(T item)
        {
            _Stack.Push(item);
        }
    }
}
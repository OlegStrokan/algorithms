
using System.Collections;

namespace data_structures.data_structures.stack
{
    public class MyStack<T>  : ICloneable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;

        public void Push(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
        
        public T Peek()
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Stack with {Count} elements";
        }

        public object Clone()
        {
            var newStack = new MyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }
}
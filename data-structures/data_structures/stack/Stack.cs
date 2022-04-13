
namespace data_structures.data_structures.stack
{
    public class MyStack<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;

        public void Push(T item)
        {
            items.Add(item);
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
                var item = items.LastOrDefault();
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
    }
}
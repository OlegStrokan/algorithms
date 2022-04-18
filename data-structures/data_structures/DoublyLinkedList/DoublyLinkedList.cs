using System.Collections;
using data_structures.data_structures.stack;

namespace data_structures.data_structures.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public DoublyItem<T> Head { get; set; }
        public DoublyItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList() { }

        public DoublyLinkedList(T data)
        {
            var item = new DoublyItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new DoublyItem<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        public DoublyLinkedList<T> Reverse()
        {
            var result = new DoublyLinkedList<T>();

            var current = Tail;

            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }

            return result;
        }


        // перебирает элементы и возвращает в форме списка 
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>) GetEnumerator();
        }
    }
}
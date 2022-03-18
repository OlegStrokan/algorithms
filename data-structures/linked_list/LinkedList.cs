using System.Collections;

namespace data_structures.linked_list;

public class MyLinkedList<T> : IEnumerable<T>
{
    private Node<T> head; // головной/первый элемент
    private Node<T> tail; // последний/хвостовой элемент
    private int count; // количество элементов в списке

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);

        if (head == null)
            head = node;
        else
            tail.Next = node;
        tail.Next = node;
        count++;
    }

    public bool Remove(T data)
    {
        Node<T> current = head;
        Node<T> previous = null;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                        tail = previous;
                }
                else
                {
                    head = head.Next;
                    if (head == null)
                        tail = null;
                }

                count--;
                return true;
            }

            previous = current;
            current = current.Next;
        }

        return false;
    }

    public bool Contains(T data)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
        }

        return false;
    }

    public void AppendFirst(T data)
    {
        Node<T> node = new Node<T>(data);
        node.Next = head;
        head = node;
        if (count == 0)
            tail = head;
        count++;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable) this).GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        Node<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
}
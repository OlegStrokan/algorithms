namespace data_structures.linked_list;

public class Node<T>
{
    public Node(T data)
    {
        Data = data;
    }
    public T Data { get; set; }
    public Node<T> Next { get; set; }
}
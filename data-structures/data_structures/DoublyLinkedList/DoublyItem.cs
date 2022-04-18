namespace data_structures.data_structures.DoublyLinkedList
{
    public class DoublyItem<T>
    {
        public T Data { get; set; }
        public DoublyItem<T> Previous { get; set; }
        public DoublyItem<T> Next { get; set; }

        public DoublyItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
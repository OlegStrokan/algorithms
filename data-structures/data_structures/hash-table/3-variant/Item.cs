namespace data_structures.data_structures.hash_table._3_variant;

public class Item<T>
{
    public int Key { get; set; }
    public List<T> Nodes { get; set; }

    public Item(int key)
    {
        Key = key;
        Nodes = new List<T>();
    }
}
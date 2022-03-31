namespace data_structures;

public class MyLinkedList
{
    public static List<string> items = new List<string>() {"Oleh", "Tom"};
    public static LinkedList<string> linkedItems = new LinkedList<string>(items);

    void PrintList()
    {
        foreach (string item in linkedItems)
        {
            Console.WriteLine();
        }

        var currentNode = linkedItems.First;
        var nextNode = currentNode?.Next;
        var previousNode = currentNode?.Previous;
    }
    
}
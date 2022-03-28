using System.Collections;

namespace data_structures;

public class BinaryTreeNode
{
    public BinaryTreeNode Left { get; set; }

    public BinaryTreeNode Right { get; set; }

    public int Data { get; set; }
}


public class BreadthFirstSearch
{
    private Queue searchQueue;
    private BinaryTreeNode root;

    public BreadthFirstSearch(BinaryTreeNode rootNode)
    {
        searchQueue = new Queue();
        root = rootNode;
    }

    public bool Search(int data)
    {
        BinaryTreeNode current = root;
        searchQueue.Enqueue(root);

        while (searchQueue.Count != 0)
        {
            current = searchQueue.Dequeue() as BinaryTreeNode;
            if (current?.Data == data)
            {
                return true;
            }
            else
            {
                searchQueue.Enqueue(current?.Left);
                searchQueue.Enqueue(current?.Right);
            }
        }

        return false;
    }
}
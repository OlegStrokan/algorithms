namespace data_structures;

public class MyQueue
{
    public Queue<string> queue = new Queue<string>();

    public void AddToQueue(string element)
    {
        queue.Enqueue(element);
    }
    
    public void RemoveFromQueue(string element)
    {
        queue.Dequeue();
    }
}
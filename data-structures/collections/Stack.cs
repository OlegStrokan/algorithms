namespace data_structures;

public class MyStack
{
    public Stack<string> stack = new Stack<string>();
    
    public void AddToStack( string element)
    {
        stack.Push(element);
    }

    public bool ContainsStack(string element)
    {
       return stack.Contains(element);
    }
    
    // возвращает первый элемент стэка и удаляет его
    public void FirstEl()
    {
         stack.Pop();
    }
    // возвращает первый элемент стэка без удаления
    public string FirstEl2()
    {
         return stack.Peek();
    }
}
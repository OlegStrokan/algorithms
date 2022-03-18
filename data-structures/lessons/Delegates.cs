using System.Net.Security;

namespace data_structures;

public class Delegates
{
    public void Hello() => Console.WriteLine("Hello from delegate");
    
    public void HowAreYou() => Console.WriteLine("How are you from delegate");
    public string Name(string name)
    {
        string Name = "Hello " + name;
        return Name;
    }
}

public delegate void Delegate();
public delegate string NameDelegate(string name);


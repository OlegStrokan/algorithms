namespace data_structures;

public class Generic<T>
{
    public T Id { get; set; }

    public Generic(T id)
    {
        Id = id;
    }
}

public class GenericIn<D>
{
    public D Ceo { get; set; }

    public GenericIn(D ceo)
    {
        Ceo = ceo;
    }
}

public class Message
{
    public string Text { get; }

    public Message(string text)
    {
        Text = text;
    }
}

public class EmailMessage : Message
{
    public EmailMessage(string text) : base(text)
    {
    }
}

public class Messanger<T> where T : Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Message: {message.Text}");
    }
}

public class Person<T>
{
}
// типизация базового класса будет int, дочернего - дженерик типом
public class UniversalMessanger<T> : Generic<int>
{
    public UniversalMessanger(int id, T age) : base(id)
    {
        
    }
}

class IntPerson<T> : Generic<int>
{
    public IntPerson(int id, T age) : base(id)
    {
    }
}
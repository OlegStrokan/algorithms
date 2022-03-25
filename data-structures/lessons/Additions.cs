using System.Dynamic;

namespace data_structures;

public class Explicit
{
    public static explicit operator int (Explicit a)
    {
        return 5;
    }
}

public class Implicit
{
    public static implicit operator int(Implicit a)
    {
        return 5;
    }
}

// ref - указатели/ссылки
public class References
{
    public void Ref()
    {
        int x = 5;
        ref int xRef = ref x;
        xRef = 10;
        Console.WriteLine(x);
        x = 20;
        Console.WriteLine(x);
    }
}


// Partial classes

public partial class Notebook
{
    public void TurnOn()
    {
        Console.WriteLine("Turn on");
    }
}


public partial class Notebook
{
    // Partial methods
    partial void TurnOff()
    {
        Console.WriteLine("Turn on");
    }
}

public partial class Notebook
{
    partial void TurnOff();
    public void Reboot()
    {
        Console.WriteLine("Reboot");
    }
}


// Анонимные типы
// создаем обьект без класса
// доступны только для чтения
public class AnonymTypes
{
    public void Anon()
    {
        var user = new {Name = "Tom", Age = 34};
        
    }
}


// Кортежи

public class Tuples
{
    public void Create()
    {
        var tuple = (5, 10);
        Console.WriteLine(tuple.Item1);
    }

    public void Update()
    {
        var tuple = (count: 5, sum: 10);
        Console.WriteLine(tuple.count);
    }
    



}

// Записи - records
public record class RecordClass
{
    public string Name { get; set; }
    public RecordClass(string name) => Name = name;
}

public record struct RecordStructure {
    public string Name { get; set; }
    public RecordStructure(string name) => Name = name;
}

// чтобы сделать записи readonly - init вместо set

public record ClassInit
{
    public string Name { get; init; }
    public ClassInit(string name) => Name = name;
}
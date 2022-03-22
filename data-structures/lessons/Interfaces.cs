namespace data_structures;

public interface IMovable
{
    const int minSpeed = 0;
    static int maxSpeed = 60; 
    void Move();
    string Name { get; set; }

    delegate void MoveHandler(string messages);

    event MoveHandler MoveEvent;
}

public interface ICar
{
    int Age { get; set; }
}

internal interface IPerson
{
    int Weight { get; set; }

}

// слияние/наследование интерфейсов
public class MoveClass : IMovable, ICar, IPerson
{
    public void Move()
    {
        throw new NotImplementedException();
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public event IMovable.MoveHandler? MoveEvent;
}

public class Auto : ICar
{
    public int Age { get; set; }
}

// ограничиваем дженерики - обьект класса Messagnger будет создаваться на основе обьекта с интерфестом ICar
public class Messenger<T> where T: ICar
{
     int Age { get; set; }
     
}

// дженерик интерфейсы
interface IUser<T>
{
    T Id { get;  }
}

class User<T> : IUser<T>
{
    public T Id { get; }
}

class IntUser : IUser<int>
{
    public int Id { get; }
}

// интерфейс для копирования объектов
public interface ICloneable
{
    object Clone();
}


// класс, от когорого можно создать много копий объектов
// поверхносное копирование
public class MessangerClone : ICloneable
{
    public int Lenght { get; set; }

    public MessangerClone(int lenght)
    {
        Lenght = lenght;
    }

    public object Clone()
    {
        return new MessangerClone(Lenght);
    }
}

// глубокое копирование

public class Company
{
    public string Name { get; set; }
    public Company(string name) => Name = name;
}

public class MessangerDeepClone : ICloneable
{
    public string Message { get; set; }
    public Company Work { get; set; }

    public MessangerDeepClone(string message, Company company)
    {
        Message = message;
        Work = company;
    }

    public object Clone() => new MessangerDeepClone(Message, new Company(Work.Name));
    
}

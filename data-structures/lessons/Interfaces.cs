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
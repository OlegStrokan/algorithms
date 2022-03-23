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

public class Device
{
    public string Text { get; set; }
    public Device(string text) => Text = text;
}
public class DeviceMessage : Device
{
    public DeviceMessage(string text): base(text) { }
}

// ковариантные интерфейсы - out
interface IMessengerOut<out T>
{
    T WriteMessage(string text);
}


public class DeviceMessanger : IMessengerOut<DeviceMessage>
{
    public DeviceMessage WriteMessage(string text)
    {
        return new DeviceMessage($"+420776038763");
    }
}

// Контравариантные интерфейсы - in

interface IMessengerIn<in T>
{
    void SendMessage(T message);
}


public class SimpleMessanger : IMessengerIn<Device>
{
    public void SendMessage(Device device)
    {
        Console.WriteLine($"{device.Text}");
    }
}

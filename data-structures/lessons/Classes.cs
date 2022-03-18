namespace data_structures;

public class Classes
{
    private string name = "Oleh Strokan";
    public int age;

    public void Print()
    {
        Console.WriteLine($"Name: {name}, age: {age}");
    }
}

public class Person
{
    public string name;
    public int age;

    public Person()
    {
        Console.WriteLine("Person initialize");
        name = "Oleh";
        age = 20;
    }

    public Person(string n, int a)
    {
        Console.WriteLine("Person initialize with args");
        name = n;
        age = a;
    }

    public void Print()
    {
        Console.WriteLine($"Name is {name}, age: {age}");
    }

    public void Deconstructor(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}

// класы и структуры без модификатора доступа = internal
class State
{
    // переменные и методы без модификатора доступа = private

    string defaultVar = "default";

    private string privateVar = "private";

    protected private string protectedPrivateVar = "protected private";

    protected string protectedVar = "protected";

    internal string internalVar = "internal";

    protected internal string protectedInternalVar = "protected internal";

    public string publicVar = "public";

    void Print() => Console.WriteLine(defaultVar);

    private void PrintPrivate() => Console.WriteLine(privateVar);

    protected private void PrintProtectedPrivate() => Console.WriteLine(protectedPrivateVar);

    protected void PrintProtected() => Console.WriteLine(protectedVar);

    internal void PrintInternal() => Console.WriteLine(internalVar);

    protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalVar);

    public void PrintPublic() => Console.WriteLine(publicVar);
}

class StateConsumer
{
    public void PrintState()
    {
        State state = new State();

        // Console.WriteLine(state.defaultVar); 
        // Console.WriteLine(state.privateVar);
        // Console.WriteLine(state.protectedPrivateVar);
        // Console.WriteLine(state.protectedVar);
        Console.WriteLine(state.internalVar);
        Console.WriteLine(state.protectedInternalVar);
        Console.WriteLine(state.publicVar);
        // state.Print();
        // state.PrintPrivate();
        // state.PrintProtectedPrivate();
        // state.PrintProtected();
        state.PrintInternal();
        state.PrintProtectedInternal();
        state.PrintPublic();
    }
}

public class PublicClass
{
    internal void PrintInternal() => Console.WriteLine("internal");
    protected internal void PrintProtectedInternal() => Console.WriteLine("protected internal");
    public void PrintPublic() => Console.WriteLine("public");
}

class DefaultState
{
}

internal class InternalState
{
}

class Human
{
    private int age = 42;
    private string name = "Tom";


    // модификатор для блока get/set можно установить только когда есть и get и set
    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 10)
                Console.WriteLine("Value must be larger than 10");
            else
                age = value;
        }
    }

    public string GetName
    {
        get { return name; }
    }

    public string ChangeName
    {
        set { name = value; }
    }

    public string About
    {
        get { return $"Name is {name}, age is {age}"; }
    }

    // Автоматические свойства

    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Значения по умолчанию
    public int likesCount { private get; set; } = 23;

    public void GetFullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Likes
{
    // init блок
    public int GetlikesCount { get; init; } = 13;

    private string name;

    // сокращенная запись

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string GetName => name;
}

// перегрузка методов - один метод с разной сигнатурой работет по-разному

class Calculator
{
    public void Add(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"Result a + b is: {result}");
    }

    public void Add(int a, int b, int c)
    {
        int result = a + b + c;
        Console.WriteLine($"Result a + b + c is: {result}");
    }

    public void Add(int a, int b, int c, int d)
    {
        int result = a + b + c + d;
        Console.WriteLine($"Result a + b + c + d is: {result}");
    }

    public void Add(double a, double b)
    {
        double result = a + b;
        Console.WriteLine($"Result a + b (double) is: {result}");
    }
}
// статистические поля, свойства и методы

class CheckPerson
{
    // поля
    private int age;
    private static int retirementAge = 65;
    private static int counter = 0;

    public CheckPerson(int age)
    {
        this.age = age;
    }

    // свойства
    public void CheckAge()
    {
        if (age >= retirementAge)
            Console.WriteLine("Too old");
        else
            Console.WriteLine($"You have: {retirementAge - age}");
    }

    public static int Counter => counter;

    public CheckPerson()
    {
        counter++;
    }

    public double Age { get; set; }
    private static int AdultAge = 18;

    public CheckPerson(double age) => Age = age;

    // методы
    public static void IsAdult(CheckPerson person)
    {
        if (person.Age >= AdultAge)
            Console.WriteLine("Welcome");
        else
            Console.WriteLine("Fuck off");
    }

    // статистические конструкторы и классы


    static class Operations
    {
        private static int retirementAge;
        public static int RetirementAge => retirementAge;

        static Operations()
        {
            if (DateTime.Now.Year == 2022)
                retirementAge = 65;
            else
                retirementAge = 67;
        }
    }
}

// readonly - значения, которые можно присвоить либо при обьявлении, либо в конструкторе

class User
{
    public readonly string name = "Oleh";

    public User(string name)
    {
        this.name = name;
    }
}

readonly struct UserStruct
{
    public readonly string Name { get; }
    public int Age { get; }
}

// преимущество nullable над null - програма не завершает работу, когда в метод попадает null
// ?? то же самое что и ??=
struct Nullable
{
    private string? name = null;

    void PrintUpper(string? text)
    {
        Console.WriteLine(text.ToUpper());
    }

    void PrintUpperCase(string? text)
    {
        if (text is not null)
            Console.WriteLine(text.ToUpper());
    }

    private static string? text = null;
    private string lastName = text ?? "Oleh";

    private static int? id = 200;
    private int personId = id ?? 1;

    void NullUnion()
    {
        Console.WriteLine(lastName, personId);
    }
    
    public Nullable()
    {
        
    }
}
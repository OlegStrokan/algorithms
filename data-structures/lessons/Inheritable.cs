namespace data_structures;

public class Programs
{
    private string name = "";
    private string lasname = "";

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string LastName
    {
        get { return lasname; }
        set { lasname = value; }
    }

    public Programs(string name)
    {
        this.name = name;
    }

    //  this (name) - основываясь на предыдущем конструкторе

    public Programs(string name, string lastname) : this(name)
    {
        this.lasname = lastname;
    }
}

public class Compiler : Programs
{
    private string company;
    public string Company { get; set; } = "";

    //  this (name) - основываясь на наследуемом конструктуре
    public Compiler(string name, string lastname, string company) : base(name, lastname)
    {
        this.company = company;
    }
}

public class TestPrograms
{
    public void Compiler()
    {
        Programs programs = new Programs("Oleh", "Strokan");
        Compiler? compiler = programs as Compiler;

        if (compiler == null)
            Console.WriteLine("some error");
        else
            Console.WriteLine(compiler.Company);


        if (programs is Compiler compile)

            Console.WriteLine(compile.Company);
    }
}

// virtual методы/свойства - методы которые можно изменять в дочернем классе
// нельзя сделать virtual static
public class VirtualClass
{
    public string Variable { get; set; }

    private int age = 1;

    public virtual int Age
    {
        get => age;
        set
        {
            if (value > 0 && value < 110) age = value;
        }
    }

    public VirtualClass(string variable)
    {
        Variable = variable;
    }

    public virtual void Print()
    {
        Console.WriteLine(Variable);
    }

    public virtual void PrintSealed()
    {
        Console.WriteLine(Variable);
    }

    public void PrintNew()
    {
        Console.WriteLine("This is shadowing/hiding method");
    }
}

public class OverrideClass : VirtualClass
{
    public string Company { get; set; }

    public override int Age
    {
        get => base.Age;
        set
        {
            if (value > 17 && value < 110) base.Age = value;
        }
    }

    public OverrideClass(string name, string company) : base(name)
    {
        Company = company;
    }

    public override void Print()
    {
        Console.WriteLine($"{Variable} is {Company}");
        base.Print();
        base.Age = 18;
    }

    public sealed override void PrintSealed()
    {
        Console.WriteLine($"{Age} and {Variable}");
    }

    public new void PrintNew()
    {
        Console.WriteLine($"Company: {Company} from print new");
    }
}

// abstract class - общий класс, который не имеет конктеных сущнестей
// используються для описания общего функционала

abstract class Transport
{
    public void Move()
    {
        Console.WriteLine("Move!");
    }

    public abstract void AbstractMove();
    
    public abstract int Speed { get; set; }
}

class Car : Transport
{
    private int speed;
    // абстрактные методы всегда должны быть переопределены
    public override void AbstractMove()
    {
        Console.WriteLine("Console log from Car");
    }

    public override int Speed
    {
        get => speed;
        set => speed = value;
    }
}
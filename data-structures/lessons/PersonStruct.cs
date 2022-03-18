namespace data_structures;

public struct PersonStruct
{
    public string name;
    public int age;

    public void Print()
    {
        Console.WriteLine($"Name: {name}, age: {age}");
    }
}
namespace data_structures.sorts;

public class NativeSort
{
    public void Sort()
    {
        int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
        Array.Sort(numbers);
        foreach (int n in numbers)
            Console.WriteLine(n);
    }
}


public class SortForObjects : IComparable
{
    public string Name { get; }
    public int Age { get; set; }

    public SortForObjects(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(object? o)
    {
        if (o is SortForObjects person) return Name.CompareTo(person.Name);
        else throw new ArgumentException("Bad values");
    }
}
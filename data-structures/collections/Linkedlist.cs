namespace data_structures;

public class Country
{
    public string Name { get; set; }

    public Country(string name)
    {
        Name = name;
    }
}
public class LinkedList
{
    public static List<string> people = new List<string>() {"Oleh", "Tom"};
    public static List<string> employees = new List<string>(people);
    // начальная емкость списка
    public static List<Country> countries = new List<Country>(4)
    {
        new Country("Ukraine"),
        new Country("Czech Republic")
    };
    
    // получаем первого работника
    private string testCountry = employees[0];

    void PrintCount()
    {
        // длина списка
        Console.WriteLine(countries.Count);
    }

    void PrintForEach()
    {
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }

    void AddToList(List<string> list, string element)
    {
        list.Add(element);
    }

    void AddRangeToList(List<string> list, string[] elements)
    {
        list.AddRange(elements);
    }

    void InsertToList(List<string> list, string firstElement)
    {
        list.Insert(0,firstElement);
    }
    void RemoveForIndex(List<string> list, int index)
    {
        list.RemoveAt(index);
    }
    void RemoveForName(List<string> list, string removedElement)
    {
        list.Remove(removedElement);
    }
    void clearList(List<string> list)
    {
        list.Clear();
    }
    
    void SearchElement(List<string> list, string searchedElement)
    {
        list.Contains(searchedElement);
    }
    
    void ReverseList(List<string> list)
    {
        list.Reverse();
    }
    void GetRangeList(List<string> list)
    {
        list.GetRange(1,3);
    }
}
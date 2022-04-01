namespace data_structures;

public class MyDictionary
{
    public Dictionary<int, string> dictionary = new Dictionary<int, string>() {{5, "Tom"}, {32, "Oleh"}};

    public void getValue()
    {
        string oleh = dictionary[2];
        Console.WriteLine(oleh);
    }

    public void AddToDictionary(int key, string value)
    {
        dictionary.Add(key, value);
    }
    
    public void ClearDictionary()
    {
        dictionary.Clear();
    }

    
    public void ContainsInDictionary( string value)
    {
        dictionary.ContainsValue( value);
    }

    
    public void RemoveFromDictionary(int key)
    {
        dictionary.Remove(key);
    }

    
}
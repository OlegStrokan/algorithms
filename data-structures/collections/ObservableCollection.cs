using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace data_structures;

public class ObservableCollection
{
    private ObservableCollection<string> people = new ObservableCollection<string>()
    {
        "Tom",
        "Oleh"
    };

    public void PrintFirst()
    {
        Console.WriteLine(people[1]);
    }

    public void AddToCollection(string value)
    {
        people.Add(value);
    }

    public void ClearCollection()
    {
        people.Clear();
    }

    public void InsertToCollection(int index, string value)
    {
        people.Insert(index, value);
    }

    public bool ContainsInCollection(string value)
    {
        return people.Contains(value);
    }


    public void RemoveFromCollection(string key)
    {
        people.Remove(key);
    }
}

public class SubscribeCollections
{
    private ObservableCollection<Person> people = new ObservableCollection<Person>()
    {
        new Person("Tom", 22),
        new Person("Oleh", 20),
    };

    // уведомление об изменении коллекции
    public void People_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                if (e.NewItems?[0] is Person newPerson)
                    Console.WriteLine($"Added new element: {newPerson.name}");
                break;

            case NotifyCollectionChangedAction.Remove:
                if (e.OldItems?[0] is Person oldPerson)
                    Console.WriteLine($"Added new element: {oldPerson.name}");
                break;
            case NotifyCollectionChangedAction.Replace:
                if ((e.NewItems?[0] is Person replacingPerson) && (e.OldItems?[0] is Person replacedPerson))
                    Console.WriteLine($"Object {replacedPerson.name} has been replaced {replacingPerson.name}");
                break;
        }
    }

    public void Subscribe()
    {
        people.CollectionChanged += People_CollectionChanged;
    }
}
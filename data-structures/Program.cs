using System;
using data_structures;
using data_structures.sorts;
using System.Collections.ObjectModel;
using data_structures.data_structures.graph_2;
using data_structures.graph;
using data_structures.leetcode;

class Program
{
    static void Main(string[] args)
    {
        /*Human oleh = new Human();
        int age = oleh.Age;
        string name = oleh.GetName;
        oleh.ChangeName = "Tomas" + 1;
        oleh.GetFullName("Oleh", "Strokan");
        // Likes tomasConstructor = new(12);
        Likes tomasInitializer = new() {GetlikesCount = 12};
        Calculator calc = new Calculator();
        calc.Add(1, 2);
        calc.Add(1, 2, 3);
        calc.Add(1, 2, 3, 4);
        calc.Add(1.489, 23.923);
        CheckPerson youngPerson = new(20);
        youngPerson.CheckAge();
        CheckPerson oldPerson = new(65);
        oldPerson.CheckAge();
        CheckPerson test = new CheckPerson();
        CheckPerson test2 = new CheckPerson();
        CheckPerson test3 = new CheckPerson();
        Console.WriteLine(CheckPerson.Counter);
        CheckPerson.IsAdult(oldPerson);
        Programs programs = new Programs("Oleh", "Strokan");
        //
        Compiler? compiler = programs as Compiler;
        Transport car = new Car();
        Generic<int> person = new Generic<int>(12);
        GenericIn<Generic<int>> microsoft = new GenericIn<Generic<int>>(person);

        // в sendMessage можно передать только обьекты типа message и его производных
        void SendMessage<T>(T message) where T : Message
        {
            Console.WriteLine($"Message from: {message.Text}");
        }

        SendMessage(new EmailMessage("Hello"));
        Messanger<Message> telegram = new Messanger<Message>();
        telegram.SendMessage(new Message("Hello"));

        Generic<int> person2 = new IntPerson<float>(12, 28.2f);
        Exceptions exception = new Exceptions(5, 12);

        Delegates delegates = new Delegates();
        // делегат указывает на 2 метода
        Delegate deleg = delegates.Hello;
        deleg += delegates.HowAreYou; 
        //лямбда выражения - упрощенная запись анонимных методов
        Delegate delegLambda = () => Console.WriteLine("Hello");
        delegLambda();
        
        NameDelegate nameDeleg = delegates.Name;
        string newDeleg = nameDeleg("Oleh");
        deleg();

        MyLinkedList<string> linkedList = new MyLinkedList<string>();
        
        void DisplayMessage(string message) => Console.WriteLine(message);

        Events.Account account = new Events.Account(100);
        account.Notify += DisplayMessage;
        account.Put(20);

        Files file = new Files();
        file.WriteToGile();
        file.StreamsRead();
        file.StreamsWrite();
        
     IMovable tom = new MoveClass();
     tom.Move();

     Auto auto = new Auto();
     var messenger = new Messenger<Auto>();

     IUser<int> user1 = new User<int>();
     IUser<int> user2 = new IntUser();

     var tom = new MessangerClone(12);
     var bob = (MessangerClone) tom.Clone();
     // не затрагиваем длину объекта tom
     bob.Lenght = 10;

     IMessengerOut<DeviceMessage> iphone = new DeviceMessanger();
     Device phone = iphone.WriteMessage("+380931117498");

     var obj1 = new Explicit();
     var obj2 = new Implicit();
     
     // explicit - явное преобразование
     int integer1 = (int) obj1;

     // implicit - неявное преобразование
     int integer2 = obj2;

     References references = new References();
    references.Ref();

        Search search = new Search();
        int[] arr = new int[] {32, 12, 13, 643, 34};

        int linearResult = search.LinearSearch(12, arr);
        int binaryResult = search.BinarySearch(643, arr);
        int recursiveBinaryResult = search.RecursiveBinarySearch(arr, 12, 0, arr.Length);
        Console.WriteLine($"Result from linear search is {linearResult}");
        Console.WriteLine($"Result from binary search is {binaryResult}");
        Console.WriteLine($"Result from recursive binary search is {recursiveBinaryResult}");

        Sorts sorts = new Sorts();
        int[] selectionResult = sorts.SelectionSort(new int[] {7, 2, 32, 1}); Console.WriteLine(selectionResult);

        List<int> quickResult = sorts.QuickSort(new List<int>{2,3,5,1});
        
        Console.WriteLine(quickResult);

        SubscribeCollections subscribe = new SubscribeCollections();
        var collection = new ObservableCollection<Person>()
        {
            new Person("Tom", 22),
            new Person("Oleh", 20),
        };

        collection.CollectionChanged += subscribe.People_CollectionChanged;


        ContainsDuplicate containsDuplicate = new ContainsDuplicate();
        
        Console.WriteLine(containsDuplicate.IsContaining(new int[] {1, 3, 2, 1}));
        
        Graph graph = new Graph();
        graph.AddVertex("1");
        graph.AddVertex("2");
        graph.AddVertex("3");
        graph.AddEdge("1", "2", 5);
        graph.AddEdge("1", "3", 1);
        graph.AddEdge("2", "3", 10);
        graph.PrintGraph();

        
 */
        Graph2 graph2 = new Graph2();

        Vertex2 v1 = new Vertex2(1);
        Vertex2 v2 = new Vertex2(2);
        Vertex2 v3 = new Vertex2(3);
        Vertex2 v4 = new Vertex2(4);
        Vertex2 v5 = new Vertex2(5);
        Vertex2 v6 = new Vertex2(6);
        Vertex2 v7 = new Vertex2(7);
        
        graph2.AddVertex(v1);
        graph2.AddVertex(v2);
        graph2.AddVertex(v3);
        graph2.AddVertex(v4);
        graph2.AddVertex(v5);
        graph2.AddVertex(v6);
        graph2.AddVertex(v7);
        
        graph2.AddEdge(v1, v2);
        graph2.AddEdge(v1, v3);
        graph2.AddEdge(v3, v4);
        graph2.AddEdge(v2, v5);
        graph2.AddEdge(v2, v6);
        graph2.AddEdge(v6, v5);
        graph2.AddEdge(v5, v6);

        var matrix = graph2.GetMatrix();
        for (int i = 0; i < graph2.VertexesCount; i++)
        {
            Console.Write(i + 1);
            for (int j = 0; j < graph2.VertexesCount; j++)
            {
                Console.Write("|"+ matrix[i,j] + "|");
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------------------");
        Console.Write(" ");
        for (int i = 0; i < graph2.VertexesCount; i++)
        {
            Console.Write($"|{ i + 1 }|");
        }

        Console.ReadLine();
    }
}
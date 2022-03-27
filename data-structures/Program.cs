using System;
using data_structures;
using data_structures.sorts;

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
     */

        Search search = new Search();

        int linearResult = search.LinearSearch(2, new int[] {1, 2, 3, 4});
        int binaryResult = search.BinarySearch(2, new int[] {1, 3, 4, 5});

        Console.WriteLine($"Result from linear search is {linearResult}");
        Console.WriteLine($"Result from binary search is {binaryResult}");

        Sorts sorts = new Sorts();
        int[] selectionResult = sorts.SelectionSort(new int[] {7, 2, 32, 1}); Console.WriteLine(selectionResult);

        List<int> quickResult = sorts.QuickSort(new List<int>{2,3,5,1});
        
        Console.WriteLine(quickResult);
    }
}
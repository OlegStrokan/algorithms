using System;
using data_structures;
using data_structures.files;
using data_structures.linked_list;
using Delegate = data_structures.Delegate;

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
     */

     Auto auto = new Auto();
     var messenger = new Messenger<Auto>();

     IUser<int> user1 = new User<int>();
     IUser<int> user2 = new IntUser();

     var tom = new MessangerClone(12);
     var bob = (MessangerClone) tom.Clone();
     // не затрагиваем длину объекта tom
     bob.Lenght = 10;
     

    }
}


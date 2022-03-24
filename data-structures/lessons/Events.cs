namespace data_structures;

public class Events
{
    public class Account
    {
        public delegate void AccountHandler(string message);

        public event AccountHandler? Notify;
 
        public int Sum { get; private set; }

        public Account(int sum) => Sum = sum;

        public void Put(int sum)
        { 
            Sum += sum;
            Notify?.Invoke($"You have: {sum}");
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
            }
        }
    }
    
}

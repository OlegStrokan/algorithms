using System.Runtime.CompilerServices;

namespace data_structures;

public class Test
{
    public static void TestFunc()
    {
        bool isAuth = true;
        byte personAge = 12;
        sbyte personHeight = 127;
        short personWeight = 32123;
        ushort personNewHeight = 32923;
        int personCount = 329329382;
        uint personCount2 = 999329382;
        long personCount3 = 189092989382;
        ulong personCount4 = 10889239483892;
        float personCount5 = 3.23f;
        double personCount6 = 3.23;
        decimal personCount7 = 3.23m;
        char personCount8 = 'A';
        char personCount9 = '\x5A';
        char personCount10 = '\u0420';
        string personName = "Oleh";
        object personSurname = "Strokan";
        System.Object personObject = 20;
        Console.WriteLine($"This is auth state {isAuth}");
        Console.WriteLine("Enter your name");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter you age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hello {name}. Are you {age} years old?");
        byte a = 70;
        // преобразования типов
        byte b = (byte) (a + 4);
        ushort c = 80;
        byte d = (byte) c;
        double value = 4.0;
        decimal newValue = (decimal) value;

        try
        {
            int variable = 33;
            int variable2 = 600;
            // cheched - выбрасывает исключения о переисполнении
            byte result = checked((byte) (variable + variable2));
            Console.WriteLine(result);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }

        int x = 10;
        int y = 20;
        int z = x != y ? (x + y) : (x - y);
        Console.WriteLine(z);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        foreach (char val in "Oleh")
        {
            Console.WriteLine(val);
        }

        int[] nums = new int [5];
        int[] array = {1, 2, 3, 4, 5};
        string[] people = {"Tom", "Oleh"};
        var index = nums[2];

        foreach (var val in array)
        {
            Console.WriteLine(val);
        }

        int per = array.GetUpperBound(0);
        Console.WriteLine(per);

        // количество положительных чисел

        int[] newArray = {1, -1, -2, 3, -6, 5};
        int resultArray = 0;

        foreach (var val in newArray)
        {
            if (val > 0)
            {
                resultArray++;
            }
        }

        // инферсия массива

        int[] numbers = {0, 1, 2, 3, 4};
        int n = numbers.Length;
        int k = n / 2;
        int temp;
        for (int i = 0; i < k; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[n - i - 1];
            numbers[n - i - 1] = temp;
        }

        foreach (var i in numbers)
        {
            Console.WriteLine($"{i}");
        }

        int[] unsortedArray = {43, -23, 0, 2, -12, 9, 93};

        int temporary;

        for (int i = 0; i < unsortedArray.Length - 1; i++)
        {
            for (int j = 0; j < unsortedArray.Length; j++)
            {
                if (unsortedArray[i] > unsortedArray[j])
                {
                    temporary = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[j];
                    unsortedArray[j] = temporary;
                }
            }
        }

        Console.WriteLine("Output");
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            Console.WriteLine(unsortedArray[i]);
        }
    }

    public static void PrintHello()
    {
        Console.WriteLine("Hello");
    }

    public static void SwitchMethods()
    {
        string language = "en";
        switch (language)
        {
            case "en":
                PrintHello();
                break;
            case "ua":
                TestFunc();
                break;
        }
    }

    public static void GetVariable(int x, int y)
    {
        int z = x + y;
        Console.WriteLine($"result: {z}");
    }

    public static string GetString()
    {
        return "Hello";
    }


    // out - возвращаемая переменная
    public static void Sum(int x, int y, out int result)
    {
        result = x + y;
    }


    // передаем ссылку на аргумент
    public static void Increment(ref int n)
    {
        n++;
        Console.WriteLine($"A number is: {n}");
    }

    public static void GetData(in int width, in int height, out int reactArea)
    {
        reactArea = width * height;
    }

    public static void Sum(params int[] numbers)
    {
        int result = 0;
        foreach (var n in numbers)
        {
            result += n;
        }

        Console.WriteLine(result);
    }

    int result = 0;
    int limit = 0;

    public static bool IsPassed(int number, int lim)
    {
        return number > lim;
    }

    public static void SwitchCase(int number)
    {
        switch (number)
        {
            case 1:
                Console.WriteLine("case 1");
                goto case 5;
            case 2:
                Console.WriteLine("case 2");
                break;
            case 3:
                Console.WriteLine("case 3");
                break;
            case 4:
                Console.WriteLine("case 4");
                break;
            case 5:
                Console.WriteLine("case 5");
                break;
            default:
                Console.WriteLine("default");
                break;
        }
    }

    enum DayTime
    {
        Morning,
        Afternoon,
        Evening,
        Night,
    }

    enum Actions : byte
    {
        RequestData,
        SetData,
    }

    public static void EnumFunction()
    {
        DayTime now = DayTime.Morning;

        Actions actions = Actions.SetData;

        Console.WriteLine((int) actions);
    }
    
}
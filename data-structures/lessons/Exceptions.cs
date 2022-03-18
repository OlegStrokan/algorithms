namespace data_structures;

public class Exceptions
{
    public int Id { get;  set; }
    public int Age { get;  set; }
    public int Result { get;  set; }

    public Exceptions(int id, int age)
    {
        try
        {
            if (Id == 5)
            {
                throw new Exception("Id can not be 5");
            }
            this.Id = id;
            this.Age = age;
            this.Result = id + age / 0;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }  
        
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        
        catch (InvalidCastException e)
        {
            Console.WriteLine(e.Message);
        } 
        
        catch (NullReferenceException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    

}
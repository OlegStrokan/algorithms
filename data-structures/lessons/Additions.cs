namespace data_structures;

public class Explicit
{
    public static explicit operator int (Explicit a)
    {
        return 5;
    }
}

public class Implicit
{
    public static implicit operator int(Implicit a)
    {
        return 5;
    }
}
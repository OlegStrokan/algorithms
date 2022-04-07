namespace data_structures.data_structures.graph_2;

public class Vertex2
{
    public int Number { get; set; }


    public Vertex2(int number)
    {
        Number = number;
    }
    public override string ToString()
    {
        return Number.ToString();
    }
}
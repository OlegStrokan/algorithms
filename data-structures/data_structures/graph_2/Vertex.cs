namespace data_structures.data_structures.graph_2;

public class Vertex
{
    public int Number { get; set; }


    public Vertex(int number)
    {
        Number = number;
    }
    public override string ToString()
    {
        return Number.ToString();
    }
}
namespace data_structures.data_structures.graph_2;

public class Edge2
{
    public Vertex2 From { get; set; }
    
    public Vertex2 To { get; set; }

    public int Weight { get; set; }

    public Edge2(Vertex2 from, Vertex2 to, int weight = 1)
    {
        From = from;
        To = to;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"({From}: {To})";
    }
}
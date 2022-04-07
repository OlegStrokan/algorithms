namespace data_structures.data_structures.graph_2;

public class Graph2
{
    List<Vertex2> Vertexes = new List<Vertex2>();
    List<Edge2> Edges = new List<Edge2>();


    public int VertexesCount => Vertexes.Count;
    public int EdgesCount => Edges.Count;
    public void AddVertex(Vertex2 vertex)
    {
        Vertexes.Add(vertex);
    }

    public void AddEdge(Vertex2 from, Vertex2 to)
    {
        Edge2 edge = new Edge2(from, to);
        Edges.Add(edge);
    }
    

    public int[,] GetMatrix()
    {
        var matrix = new int [Vertexes.Count, Vertexes.Count];

        foreach (var edge in Edges)
        {
            var row = edge.From.Number - 1;
            var column = edge.To.Number - 1;
            matrix[row, column] = edge.Weight;
        }
        return matrix;
    }
    
}
namespace data_structures.data_structures.graph_2;

public class Graph2
{
    List<Vertex> Vertexes = new List<Vertex>();
    List<Edge> Edges = new List<Edge>();


    public int VertexesCount => Vertexes.Count;
    public int EdgesCount => Edges.Count;
    public void AddVertex(Vertex vertex)
    {
        Vertexes.Add(vertex);
    }

    public void AddEdge(Vertex from, Vertex to)
    {
        Edge edge = new Edge(from, to);
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

    public List<Vertex> GetVertexLists(Vertex vertex)
    {
        List<Vertex> result = new List<Vertex>();

        foreach (var edge in Edges)
        {
            if (edge.From == vertex)
            {
                result.Add(edge.To);
            }
        }
        return result;
    }

}
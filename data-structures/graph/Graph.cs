namespace data_structures.graph;

public class Graph
{
    // Список вершин графа
    public List<GraphVertex> Vertices { get; }


    public Graph()
    {
        Vertices = new List<GraphVertex>();
    }
    
    // Добавление вершини
    public void AddVertex(string vertexName)
    {
        Vertices.Add(new GraphVertex(vertexName));
    }
    
    // поиск вершини
    public GraphVertex? FindVertex(string vertexName)
    {
        foreach (var v in Vertices)
        {
            if (v.Name.Contains(vertexName))
            {
                return v;
            }
        }

        return null;
    }

    /// Добавление ребра
    public void AddAge(string firstName, string secondName, int weight)
    {
        var v1 = FindVertex(firstName);
        var v2 = FindVertex(secondName);
        if (v1 != null && v2 != null)
        {
            v1.AddEdge(v2, weight);
            v2.AddEdge(v1, weight);
        }
    }
    
}
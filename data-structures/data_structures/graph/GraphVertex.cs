namespace data_structures.graph;

// вершина графа
public class GraphVertex
{
    // название вершини
    public string Name { get; }
    
    // список ребер
    public List<GraphEdge> Edges { get; }

    public GraphVertex(string vertexName)
    {
        Name = vertexName;
        Edges = new List<GraphEdge>();
    }

    // добавить ребро (ребро)
    public void AddEdge(GraphEdge edge)
    {
        Edges.Add(edge);
    }
    
    // добавить ребро (вершина, вес)
    public void AddEdge(GraphVertex vertex, int edgeWeight)
    {
        AddEdge(new GraphEdge(vertex, edgeWeight));
    }

    public override string ToString() => Name;

}
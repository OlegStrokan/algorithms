namespace data_structures.graph;

// ребро графа
public class GraphEdge
{
    
    // сзязанная вершина
    public GraphVertex ConnectedVertex { get; }
    
    // вес ребра
    public int EdgeWeight { get; }

    public GraphEdge(GraphVertex connectedVertex, int weight)
    {
        ConnectedVertex = connectedVertex;
        EdgeWeight = weight;
    }
}
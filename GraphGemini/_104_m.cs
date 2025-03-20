namespace GraphGemini;

public class _104_m
{
    public int MaxDepthOfGraph(Dictionary<int, List<int>> graph, int vertex)
    {
        var visited = new Dictionary<int, bool>();
        var count = -1;
        MaxDepthHelper(graph, 0, visited, ref count);
        return count;
    }

    private void MaxDepthHelper(Dictionary<int, List<int>> graph, int vertex, Dictionary<int, bool> visited, ref int count)
    {
        if (visited.TryAdd(vertex, true))
        {
            count++;
            if (graph.ContainsKey(vertex))
            {
                foreach (var v in graph[vertex])
                {
                    MaxDepthHelper(graph, v, visited, ref count);
                }
            }
        }

        return;
    }
}
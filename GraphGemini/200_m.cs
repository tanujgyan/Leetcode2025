namespace GraphGemini;

class _200_m
{
    public List<int> DFS(Dictionary<int, List<int>> graph)
    {
        return DFSHelper(graph, [], 0, []);
    }

    private List<int> DFSHelper( Dictionary<int, List<int>> graph, Dictionary<int, bool> visited, int vertex, List<int> result)
    {
        if (visited.TryAdd(vertex, true))
        {
            result.Add(vertex);


            foreach (var v in graph[vertex])
            {
                DFSHelper(graph, visited, v, result);
            }
        }

        return result;

    }
}
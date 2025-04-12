namespace Top150;

public class _1466
{
    private List<int> result = [];
    public int MinReorder(int n, int[][] connections)
    {
        var visited = new bool[n];
        var adj = CreateAdj(connections);
        //run dfs from node 0 to cover all outgoing edges from 0. They need to be turned around
        if (adj.ContainsKey(0))
        {
            MinReorderHelper(adj, visited,0, adj[0]);
        }
        //look for incoming edges into 0
        var edge = 0;
        // foreach (var node in adj)
        // {
        //     if (node.Value.Contains(edge))
        //     {
        //         MinReorderHelper(adj, visited, node.Key, node.Value);
        //         edge = node.Key;
        //     }
        // }

        for (int i = 0; i < adj.Count; i++)
        {
            if (!visited[adj.ElementAt(i).Key])
            {
                MinReorderHelper(adj, visited, adj.ElementAt(i).Key, adj.ElementAt(i).Value);
                edge = adj.ElementAt(i).Key;
            }
        }
        foreach (var node in adj)
        {
            if (!visited[node.Key])
            {
                MinReorderHelper(adj, visited, node.Key, node.Value);
            }
            
        }

        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
        return 0;
    }
    
    private void MinReorderHelper(Dictionary<int, List<int>> adj, bool[] visited, int node, List<int> neghibors)
    {
        if (visited[node])
        {
            return;
        }

        visited[node] = true;
        result.Add(node);
        for(int i=0;i<neghibors.Count;i++)
        {
            MinReorderHelper(adj, visited, neghibors[i], adj.ContainsKey(neghibors[i]) ? adj[neghibors[i]] : []);
        }
        
    }
    private Dictionary<int, List<int>> CreateAdj(int[][] connections)
    {
        var adj = new Dictionary<int, List<int>>();
        for(int i=0;i<connections.Length;i++)
        {
            if (!adj.TryAdd(connections[i][0], [connections[i][1]]))
            {
                adj[connections[i][0]].Add(connections[i][1]);
            }
        }

        return adj;
    }
}
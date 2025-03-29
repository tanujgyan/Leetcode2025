namespace GraphGemini;

public class _210
{
    //TODO: We need to write logic for detecting cycles also
    public int[] FindOrder(int numCourses, int[][] prerequisites) 
    {
       
        var adj = CreateAdj(prerequisites, numCourses);
        HashSet<int> visited = new();
        List<int> sorted = new();
        foreach (var node in adj.Keys)
        {
            FindOrderHelper(adj,visited,sorted,node);
        }

        if (sorted.Count == numCourses)
        {
            return sorted.ToArray();
        }

        if (sorted.Count == 0)
        {
            for (int i = 0; i < numCourses; i++)
            {
                sorted.Add(i);
            }

            return sorted.ToArray();
        }

        for (int i = sorted.Count - 1; i < numCourses; i++)
        {
            sorted.Add(i);
        }
        return sorted.ToArray();
    }

    private void FindOrderHelper(Dictionary<int, List<int>> adj, HashSet<int> visited, List<int> sorted, int node)
    {
        if (visited.Contains(node))
        {
            return;
        }

        visited.Add(node);
        if (adj.ContainsKey(node))
        {
            foreach (var value in adj[node])
            {
                FindOrderHelper(adj, visited,sorted, value);
            }
        }
        sorted.Add(node);
    }
    private Dictionary<int, List<int>> CreateAdj(int[][] prerequisites, int numCourses)
    {
        var adj = new Dictionary<int, List<int>>();
        foreach (var p in prerequisites)
        {
            if(!adj.TryAdd(p[0],[p[1]]))
            {
                adj[p[0]].Add(p[1]);
            }
        }

        if (adj.Count < numCourses)
        {
            for (int i = 0; i < numCourses; i++)
            {
                if (!adj.ContainsKey(i))
                {
                    adj.Add(i,[]);
                }
            }
        }

        return adj;
    }
}
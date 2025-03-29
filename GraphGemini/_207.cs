public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adj = CreateAdj(prerequisites);
        var success = true;
        var visited = new Dictionary<int, bool>();
        foreach (var key in adj.Keys)
        {
            var result = DFSHelper(adj, visited, key, ref success, key);
            if (!result)
            {
                return false;
            }

            visited = [];
        }

        return true;
        
    }
    private bool DFSHelper( Dictionary<int, List<int>> adj, Dictionary<int, bool> visited, int node, ref bool success, int parent)
    {
        if (!success)
        {
            return false;
        }

      
        if (!visited.TryAdd(node, true))
        {
            success = false;
            return false;
        }

        if (adj.ContainsKey(node))
        {

            foreach (var val in adj[node])
            {
                DFSHelper(adj, visited, val, ref success, parent);
            }
        }

        visited.Remove(node);

        return success;
    }
    private Dictionary<int, List<int>> CreateAdj(int[][] prerequisites)
    {
        var adj = new Dictionary<int, List<int>>();
        foreach (var p in prerequisites)
        {
            if(!adj.TryAdd(p[0],[p[1]]))
            {
                adj[p[0]].Add(p[1]);
            }
        }

        return adj;
    }
}
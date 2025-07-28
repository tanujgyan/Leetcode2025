namespace GraphGemini;

public class TopoSortBFS
{
    public List<int> TopologicSortUsingBFS(int[][] prerequisites, int numberOfNodes)
    {
        var result = new List<int>();
        var adj = CreateAdj(prerequisites, numberOfNodes);
        Dictionary<int, int> inDegreeNodes = new();
        foreach (var node in adj.Keys)
        {
            if (!inDegreeNodes.ContainsKey(node))
            {
                inDegreeNodes.Add(node,0);
            }
            foreach (var value in adj[node])
            {
                if (inDegreeNodes.ContainsKey(value))
                {
                    inDegreeNodes[value]++;
                }
                else
                {
                    inDegreeNodes.Add(value,1);
                }
            }
        }
       
        Queue<int> queue = new();
        foreach (var value in inDegreeNodes.Keys)
        {
            if (inDegreeNodes[value] == 0)
            {
                queue.Enqueue(value);
            }
        }

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            result.Add(node);
            foreach (var value in adj[node])
            {
                inDegreeNodes[value]--;
                if (inDegreeNodes[value] == 0)
                {
                    queue.Enqueue(value);
                }
            }
        }

        if (result.Count < numberOfNodes)
        {
            return [];
        }
        result.Reverse();
         return result;
    }
    
    
    private Dictionary<int, List<int>> CreateAdj(int[][] prerequisites, int numberOfNodes)
    {
        var adj = new Dictionary<int, List<int>>();
        foreach (var p in prerequisites)
        {
            if(!adj.TryAdd(p[0],[p[1]]))
            {
                adj[p[0]].Add(p[1]);
            }
        }

        if (adj.Count < numberOfNodes)
        {
            for (int i = 0; i < numberOfNodes; i++)
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
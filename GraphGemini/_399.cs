namespace GraphGemini;

public class _399
{
    public double result = -1;
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var adj = CreateAdj(equations, values);
       IList<double> retresult = [];
        foreach (var query in queries)
        {
            if (!adj.ContainsKey(query[0]) || !adj.ContainsKey(query[1]))
            {
                retresult.Add(-1.00);
                continue;
            }

            FindPathDFS(adj, query[0], query[1], 1.00, []);
            retresult.Add(result);
            result = -1;
        }
        return retresult.ToArray();
    }

    private void FindPathDFS(Dictionary<string, Dictionary<string, double>> adj, string node, string end, double weight, HashSet<string>? visited = null,  double tempResult =1)
    {
        if (!adj.ContainsKey(end) || !adj.ContainsKey(node))
        {
            result = -1;
            return;
        }

        if (visited.Contains(node))
        {
            return;
        }

        visited.Add(node);
        tempResult *= weight;
        if (node == end)
        {
            if (result != -1)
            {
                result = Math.Min(result, tempResult);
            }
            else
            {
                result = tempResult;
            }

            return;
        }
       
        for(int i=0;i<adj[node].Count;i++)
        {
            var tempStart = adj[node].Keys.ToList()[i];
            FindPathDFS(adj,tempStart , end, adj[node][tempStart],visited,tempResult);
        }
        
    }
    private Dictionary<string, Dictionary<string, double>> CreateAdj(IList<IList<string>> equations, double[] values)
    {
        var result = new Dictionary<string, Dictionary<string, double>>();

        for (int i = 0; i < equations.Count; i++)
        {
            if (result.ContainsKey(equations[i][0]))
            {
                result[equations[i][0]].Add(equations[i][1], values[i]);
            }
            else
            {
                result.Add(equations[i][0], new Dictionary<string, double> { { equations[i][1], values[i] } });
            }
            if (result.ContainsKey(equations[i][1]))
            {
                result[equations[i][1]].Add(equations[i][0], 1/values[i]);
            }
            else
            {
                result.Add(equations[i][1], new Dictionary<string, double> { { equations[i][0], 1/values[i] } });
            }
        }

        return result;
    }
}
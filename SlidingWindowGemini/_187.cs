namespace SlidingWindowGemini;

public class _187
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        var seqDictionary = new Dictionary<string, int>();
        var result = new HashSet<string>();
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 10 > s.Length)
            {
                return result.ToList();
            }
            var substring = s.Substring(i, 10);
            if (!seqDictionary.TryAdd(substring,1))
            {
                seqDictionary[substring]++;
                if (seqDictionary[substring] == 2)
                {
                    result.Add(substring);
                }

            }
        }

        return result.ToList();
    }
}
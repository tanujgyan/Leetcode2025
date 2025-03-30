namespace SlidingWindowGemini;

public class _1876
{
    public int CountGoodSubstrings(string s)
    {
        var index1 = 0;
        var index2 = 1;
        var index3 = 2;
        if (s.Length < 3)
        {
            return 0;
        }

        var result = 0;
        while (index3 < s.Length)
        {
            if (s[index1] != s[index2] && s[index1] !=s[index3] && s[index2]!=s[index3])
            {
                result++;
            }

            index1++;
            index2++;
            index3++;
        }

        return result;
    }
}
namespace SlidingWindowGemini;

public class _3
{
    public int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;
        var chars = new List<char>();
        int left = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (!chars.Contains(s[i]))
            {
                chars.Add(s[i]);
            }
            else
            {
                maxLength = Math.Max(maxLength, chars.Count());
                var index = chars.IndexOf(s[i]);
                chars.RemoveRange(0,index+1);
                chars.Add(s[i]);
            }
          
        }

        return Math.Max(maxLength,chars.Count());
    }
}
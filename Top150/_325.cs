namespace Top150;

public class _325
{
    public int MaximuSizeSubArray(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();
        dictionary.Add(0, -1);
        var result = 0;
        var currentSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            if (!dictionary.ContainsKey(currentSum))
            {
                dictionary.Add(currentSum, i);
            }

            if (dictionary.ContainsKey(currentSum - k))
            {
                result = Math.Max(result, i - dictionary[currentSum - k]);
            }
        }
        
        return result;
    }
}
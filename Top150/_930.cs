namespace Top150;

public class _930
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var dict = new Dictionary<int, int>();
        dict.Add(0,1);
        var currentSum = 0;
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            if (dict.ContainsKey(currentSum - goal))
            {
                result += dict[currentSum - goal];
            }

            if (dict.ContainsKey(currentSum))
            {
                dict[currentSum]++;
            }
            else
            {
                dict.Add(currentSum,1);
            }
        }

        return result;
    }
}
namespace Top150;

public class _525
{
    public int FindMaxLength(int[] nums) {
        //convert all the 0s to -1
        for(int i=0;i<nums.Length;i++)
        {
            if (nums[i] == 0)
            {
                nums[i] = -1;
            }
        }

        var dict = new Dictionary<int, int>();
        dict.Add(0,-1);
        var currentSum = 0;
        var maxLength = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            if (dict.ContainsKey(currentSum))
            {
                maxLength = Math.Max(maxLength, i - dict[currentSum]);
            }
            else
            {
                dict.Add(currentSum, i);
            }
        }

        return maxLength;
    }
}
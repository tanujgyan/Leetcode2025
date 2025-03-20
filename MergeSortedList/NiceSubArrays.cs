namespace LeetCode;

public class NiceSubArrays
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int head = 0;
        int tail = k;
        int result = 0;
        for (int i = 0; i <= nums.Length - k; i++)
        {
            List<int> list = new List<int>();
            for (int j = head; j < nums.Length; j++)
            {
                if (nums[j] % 2 != 0)
                {
                    list.Add(nums[j]);
                    if (list.Count >= k && j-head<nums.Length-1)
                    {
                        result = 
                    }
                }
            }

            head++;
        }
        return result;
    }
}
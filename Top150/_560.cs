namespace Top150;

public class _560
{
    public int SubarraySum(int[] nums, int k)
    {
        var result = 0;
       var dict = new Dictionary<int,int>();
       dict.Add(0,1);
       var currentSum = 0;
       for (int i = 0; i < nums.Length; i++)
       {
           currentSum += nums[i];
           if (dict.ContainsKey(currentSum - k))
           {
               result += dict[currentSum-k];
           }

          
           if (!dict.ContainsKey(currentSum))
           {
               dict.Add(currentSum,1);
           }
           else
           {
               dict[currentSum]++;
           }
       }

       return result;
    }

    
}
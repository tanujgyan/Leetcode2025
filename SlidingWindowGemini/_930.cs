using System.Data;

namespace SlidingWindowGemini;

public class _930
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var left = 0;
        var sum = 0;
        var total = 0;
        var right = 0;
        if (nums.Length == 1 )
        {
            return nums[0] == goal ?  1 : 0;
        }
       
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == goal)
            {
                total++;
                total += CountWindows(nums, left, i);
                left++;
            }
            else if (sum == goal)
            {
                total++;
                total += CountWindows(nums,  left, i);
                sum -= nums[left];
                left++;
            }
            else if(sum+nums[i]==goal)
            {
                sum += nums[i];
                total++;
                total += CountWindows(nums,  left, i);
                sum -= nums[left];
                left++;
               
            }
            else
            {
                sum += nums[i];
            }
        }
        return total;
    }

    private int CountWindows(int[] nums,  int left,int index)
    {
        var total = 0;
        while (left < index && nums[left] == 0)
        {
            total++;
            left++;
        }

        index++;
        while (index < nums.Length && nums[index] == 0)
        {
            total++;
            index++;
        }
        
        return total;
    }
}
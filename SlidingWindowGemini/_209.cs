namespace SlidingWindowGemini;

public class _209
{
    public int MinSubArrayLen(int target, int[] nums) {
        var count = Int32.MaxValue;
        var sum = nums[0];
        var index = 1;
        var left = 0;
        if (sum >= target)
        {
            return 1;
        }

        if (nums.Length == 1 && nums[0] < target)
        {
            return 0;
        }
        while (index < nums.Length)
        {
            if (nums[index] >= target)
            {
                return 1;
            }

            sum += nums[index];
            if (sum >= target)
            {
                count = Math.Min(count, index - left + 1);
                
                while (sum - nums[left] >= target && index > left)
                {
                    sum -= nums[left];
                    left++;
                   
                }count = Math.Min(count, index - left + 1);

                sum -= nums[left];
                left++;
            }
            
            index++;
        }

        return count == Int32.MaxValue ? 0: count;
    }
   
    
}
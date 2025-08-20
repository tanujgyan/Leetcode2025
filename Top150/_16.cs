namespace Top150;

public class _16
{
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        var sum = nums[^1] + nums[^2] + nums[^3];
        if (sum == target)
        {
            return target;
        }

        for (var i = 0; i < nums.Length - 3; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var tempSum = nums[i] + nums[left] + nums[right];
                if (Math.Abs(tempSum - target) < Math.Abs(sum - target))
                {
                    sum = tempSum;
                }
                if (tempSum > target)
                {
                    right--;
                }
                else if (tempSum < target)
                {
                    left++;
                }

                if (tempSum == target)
                {
                    return tempSum;
                }
            }
            
            
        }

        return sum;
    }
}
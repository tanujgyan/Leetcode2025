namespace BinarySearch;

public class BS704
{
    public int Search(int[] nums, int target)
    {
        if (target < nums[0] || target > nums[^1])
        {
            return -1;
        }
        var low = 0;
        var high = nums.Length - 1;
        while (low <= high)
        {
            var mid = (low + high) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
    
}
namespace BinarySearch;

public class BS35
{
    public int SearchInsert(int[] nums, int target) 
    {
        if (target < nums[0])
        {
            return 0;
        }
        if (target > nums[^1])
        {
           return nums.Length;
        }
        
        var low = 0;
        var high = nums.Length - 1;
        var mid = -1;
        while (low <= high)
        {
            mid = (low + high) / 2;
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

        return low;
    }
}
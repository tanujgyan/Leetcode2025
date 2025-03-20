namespace BinarySearch;

public class BS33
{
    public int Search(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;
        var mid = -1;
        while (low <= high)
        {
            mid = (high+low)/2;
            if (nums[mid] == target)
            {
                return mid;
            }
            //sorted half is on left and target may be there
            if (nums[mid] >= nums[low] && target>=nums[low] && target<nums[mid])
            {
                high = mid - 1;
            }
            //sorted half is on right and target may be there
            else if (nums[mid] <= nums[high] && target <= nums[high] && target > nums[mid])
            {
                low = mid + 1;
            }
            //if left half is not sorted, then right half must be sorted and target was not found in right half
            else if (nums[mid] < nums[low])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
    }
}
namespace BinarySearch;

public class BS153
{
    public int FindMin(int[] nums) {
        var low = 0;
        var high = nums.Length - 1;
        var mid = -1;
        int min = int.MaxValue;
        while (low <= high)
        {
            mid = (low + high) / 2;
            //means array left is sorted and right is not
            if (nums[low] <= nums[mid])
            {
                if (nums[low] <= min)
                {
                    min = nums[low];
                }
                low = mid + 1;
            }
            //means right array is sorted and left is not
            else if (nums[mid] <= nums[high])
            {
                if (nums[mid] <= min)
                {
                    min = nums[mid];
                }
                high = mid - 1;
            }
        }

        return min;
    }
}
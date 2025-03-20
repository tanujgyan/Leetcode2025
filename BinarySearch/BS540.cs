namespace BinarySearch;

public class BS540
{
    public int SingleNonDuplicate(int[] nums) {
        var low = 0;
        var high = nums.Length - 1;
        var mid = -1;
        if (low == high)
        {
            return nums[low];
        }
        while (low <= high)
        {
            mid = (low + high) / 2;

            if(mid-1>=0 && mid+1<=nums.Length-1 && nums[mid]!=nums[mid+1] && nums[mid]!=nums[mid-1])
            {
                return nums[mid];
            }

            if (mid-1<0 && nums[mid] != nums[mid + 1])
            {
                return nums[mid];
            }
            if (mid+1> nums.Length -1 && nums[mid] != nums[mid - 1])
            {
                return nums[mid];
            }
            
            //right element is same as mid
            if(mid+1 <=high && nums[mid+1]==nums[mid])
            {
                if ((mid - low ) % 2 == 0)
                {
                    low = mid + 2;
                }
                else
                {
                    high = mid - 1;
                }
            }
            
            //left element is same as mid
            else if (mid - 1 >= low && nums[mid - 1] == nums[mid])
            {
                if((high-mid) % 2 == 0)
                {
                    high = mid - 2;
                }
                else
                {
                    low = mid +1;
                }
            }
        }

        return -1;
    }
}
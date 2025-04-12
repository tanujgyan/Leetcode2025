namespace Top150;

public class _334
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }
        int first = nums[0];
        int second = Int32.MaxValue;
        
        for(int i=1;i<nums.Length;i++)
        {
            if (nums[i] < first)
            {
                first = nums[i];
            }
            else if (nums[i] > first && nums[i] < second)
            {
                second = nums[i];
            }
            else if (nums[i] > second)
            {
                return true;
            }
        }

        return false;
    }
}
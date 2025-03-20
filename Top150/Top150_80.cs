namespace Top150;

public class Top150_80
{
    public int RemoveDuplicates(int[] nums)
    {
       
       
        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        int slow = 2;
        for (int fast = 2; fast < nums.Length; fast++)
        {
            if (nums[fast] != nums[slow - 2])
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }

        return slow;
    }
}
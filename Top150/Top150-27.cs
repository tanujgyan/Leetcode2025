namespace Top150;

public class Top150_27
{
    public int RemoveElement(int[] nums, int val)
    {
        var slow = 0;
        var fast = 0;
        for (; fast < nums.Length; fast++)
        {
            if (nums[fast] != val)
            {
                nums[slow] = nums[fast];
                slow++;
            }
            
        }

        return slow;
    }
}
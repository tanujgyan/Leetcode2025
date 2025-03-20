namespace Top150;

public class _283 {
    public void MoveZeroes(int[] nums)
    {
        var slow = 0;
        var fast = 0;
        for (; fast < nums.Length; fast++)
        {
            if (nums[fast] != 0 && nums[slow] ==0)
            {
                nums[slow] = nums[fast];
                nums[fast] = 0;
                slow++;
            }
            else if (nums[slow] != 0)
            {
                slow++;
            }
        }
    }
}
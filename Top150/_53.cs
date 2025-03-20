namespace Top150;

public class _53
{
    public int MaxSubArray(int[] nums)
    {
        //the first will be the max and second will be the best we can get right now
        var arr = new int[]{nums[0], nums[0]};
        for (int i = 1; i < nums.Length; i++)
        {
            arr[1] = Math.Max(Math.Max(arr[1] + nums[i], nums[i]), nums[i]+nums[i-1]);
            arr[0] = Math.Max(arr[0], arr[1]);
        }

        return arr[0];
    }
}
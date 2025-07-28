namespace Top150;

public class _219
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],i);
            }
            else
            {
                if (Math.Abs(dict[nums[i]] - i) <= k)
                {
                    return true;
                }
                    dict[nums[i]] = i;
            }
        }

        return false;
    }
}
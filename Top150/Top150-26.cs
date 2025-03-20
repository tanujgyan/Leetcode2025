namespace Top150;

public class Top150_26
{
    public int RemoveDuplicates(int[] nums)
    {
        
        if (nums.Length == 1 || nums[0] == nums[^1])
        {
            return 1;
        } 
        if (nums.Length == 2 && nums[0] != nums[1])
        {
            return 2;
        }

        var lastSeen = nums[0];
        var first = 1;
        var second = 2;
        while (second < nums.Length)
        {
            //means we need to replace nums[first]
            if (nums[first] <= lastSeen && nums[second] >lastSeen)
            {
                nums[first] = nums[second];
                lastSeen = nums[first];
                first++;
                second++;
                
            }
            else if(nums[first] <=lastSeen && nums[second] <=lastSeen)
            {
                second++;
            }
            else if(nums[first]>lastSeen)
            {
                lastSeen = nums[first];
                first++;
                second++;
                
            }
        }

        if (nums[^1] > lastSeen)
        {
            first++;
        }
        return first;
    }
}
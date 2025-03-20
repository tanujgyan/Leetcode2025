namespace BinarySearch;

public class BS34
{
    public int[] SearchRange(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;
        int[] retVal = [-1, -1];
        var dictionary = new Dictionary<string, int>
        {
            {"left", 0},
            {"right", high},
            {"mid", -1},
            {"leftFound", -1},
            {"rightFound", -1}
        };
        //first iteration. This will give us the first occurence of target
        BinarySearch(nums, low, high, target, dictionary);
        //if target is not found
        if(dictionary.ContainsKey("TargetNotFound"))
        {
            return [-1, -1];
        }
        
        //search for the leftmost target
        while (dictionary["leftFound"] == -1 )
        {
                low = 0;
                high = dictionary["left"];
                BinarySearch(nums, low, high, target, dictionary,"left");
        }
        if(dictionary["leftFound"] == 1)
        {
            retVal[0] = dictionary["left"];
        }
        
        //search for the rightmost target
        while (dictionary["rightFound"] == -1)
        {
            if(dictionary["rightFound"] == -1)
            {
                low = dictionary["right"];
                high = nums.Length - 1;
                BinarySearch(nums, low, high, target, dictionary, "right");
               
            }
        }
        if(dictionary["rightFound"] == 1)
        {
            retVal[1] = dictionary["right"];
        }

        return retVal;
    }

    public void BinarySearch(int[] nums, int low, int high, int target, Dictionary<string, int> dictionary, string searchType = "")
    {
        int mid = -1;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                if (searchType == "")
                {
                    dictionary["left"] = mid;
                    dictionary["right"] = mid;
                    return;
                }
                else if (searchType == "left")
                {
                    if ((mid - 1 >= 0 && nums[mid - 1] < target) || mid - 1 == -1)
                    {
                        dictionary["left"] = mid;
                        dictionary["leftFound"] = 1;
                    }
                    else if (mid - 1 >= 0 && nums[mid - 1] == target)
                    {
                        dictionary["left"] = mid - 1;
                    }
                }
                else
                {
                    if (mid + 1 <= nums.Length - 1 && nums[mid + 1] > target || mid + 1 == nums.Length)
                    {
                        dictionary["right"] = mid;
                        dictionary["rightFound"] = 1;
                    }
                    else if (mid + 1 <= nums.Length - 1 && nums[mid + 1] == target)
                    {
                        dictionary["right"] = mid + 1;
                    }
                }

                return;
            }
        }
    }
}
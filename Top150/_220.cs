using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace Top150;

public class _220
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        var sorted = new SortedSet<int>(nums.Skip(0).Take(indexDiff + 1));
        for (int i =1; i < nums.Length-indexDiff; i++)
        {
            sorted.Remove(nums[i - 1]);
            sorted.Add(nums[indexDiff+1]);
            if (MatchFound(sorted, valueDiff))
            {
                return true;
            }
        }

        return false;
    }

  

    private bool MatchFound(SortedSet<int> sorted, int valueDiff)
    {
        foreach (var element in sorted)
        {
            var target = element + valueDiff;
            if (sorted.GetViewBetween(element, target)!=null)
            {
                return true;
            }
        }
      

        return false;
    }
    
   
}
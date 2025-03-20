namespace TreeGemini;

public class _108
{
    private TreeNode result;
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length ==  0)
        {
            return null;
        }
        else
        {
            var mid = (nums.Length-1) / 2;
            result = new TreeNode(nums[mid], SortedArrayToBST(new ArraySegment<int>(nums, 0, mid).ToArray()), SortedArrayToBST(new ArraySegment<int>(nums, mid + 1, nums.Length - mid - 1).ToArray()));
            
        }
        return result;
    }

   
}
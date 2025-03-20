namespace LeetCode;


public class RangeSumBST
{
    private int sum = 0;
    public int Traverse(TreeNode root, int low, int high)
    {
        if (root != null)
        {
            if (root.val > high)
            {
                Traverse(root.left, low, high);
            }
            else if (root.val < low)
            {
                Traverse(root.right, low, high);
            }
            else
            {
                Traverse(root.left, low, high);
                sum += root.val;
                Traverse(root.right, low, high);
            }
        }

        return sum;
    }
}
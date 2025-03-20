namespace TreeGemini;

public class _110 {
    private int diff = 0;
    public bool IsBalanced(TreeNode root) {
        diff = CalculateHeightDifference(root);
        if (diff > 1)
            return false;
        return true;
    }
    private int CalculateHeightDifference(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        CalculateHeightDifference(root.left);
        int leftHeight = CalculateHeight(root.left); // Store left subtree height
        int rightHeight = CalculateHeight(root.right); // Store right subtree height
        diff = Math.Abs(leftHeight-rightHeight);
        if (diff > 1)
        {
            return diff;
        }
        
       
        CalculateHeightDifference(root.right);
        diff = Math.Abs(CalculateHeight(root.left) - CalculateHeight(root.right));
        if (diff > 1)
        {
            return diff;
        }
       
        return diff;
    }

    private int CalculateHeight(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        return Math.Max(CalculateHeight(root.left), CalculateHeight(root.right)) + 1;
    }
}
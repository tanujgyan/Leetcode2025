namespace TreeGemini;

public class _104
{
    public int MaxDepth(TreeNode root) {
        if (root == null)
        {
            return 0;
        }
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
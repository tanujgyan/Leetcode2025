namespace TreeGemini;

public class _226
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }
        InvertTree(root.left);
        InvertTree(root.right);
        (root.right, root.left) = (root.left, root.right);
        
        return root;
    }
}
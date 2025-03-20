namespace TreeGemini;

public class _700
{
    public TreeNode SearchBST(TreeNode root, int val) 
    {
        if (root == null)
        {
            return null;
        }
        if (root.val == val)
        {
            return root;
        }
        else if (val < root.val)
        {
            if (root.left != null)
            {
                return SearchBST(root.left, val);
            }
        }

        if (val > root.val)
        {
            return SearchBST(root.right, val);
        }

        return null;
    }
}
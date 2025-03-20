namespace TreeGemini;

public class _236
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // Base case
        if (root == null)
        {
            return null;
        }
        
        // If either p or q is the root, root is the LCA
        if (root.val == p.val || root.val == q.val)
        {
            return root;
        }
        
        // Look for p and q in left and right subtrees
        TreeNode leftLCA = LowestCommonAncestor(root.left, p, q);
        TreeNode rightLCA = LowestCommonAncestor(root.right, p, q);
        
        // If both left and right returned non-null values, it means
        // p and q are in different subtrees, so root is the LCA
        if (leftLCA != null && rightLCA != null)
        {
            return root;
        }
        
        // If only left subtree has one of p or q (or their LCA)
        if (leftLCA != null)
        {
            return leftLCA;
        }
        
        // If only right subtree has one of p or q (or their LCA)
        return rightLCA;
    }
}
   
namespace TreeGemini;

public class _235
{
    private bool pFound = false;
    private bool qFound = false;
    private TreeNode LCA = null;

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        
        if (pFound && qFound || root ==null)
        {
            return LCA;
        }
        if (root.val == p.val && LCA ==null)
        {
            LCA = p;
            pFound = true;
        }
        else if (root.val == q.val && LCA == null)
        {
            LCA = q;
            qFound = true;
        }
        else if (root.val == q.val && LCA != null)
        {
            qFound = true;
        }
        else if(root.val == p.val && LCA!=null)
        {
            pFound = true;
        }
        else if (pFound && !qFound)
        {
            if (root.val == q.val)
            {
                qFound = true;
            }
            else if (root.val > q.val)
            {
                LowestCommonAncestor(root.left, p, q);
            }
            else
            {
                LowestCommonAncestor(root.right, p, q);
            }
        }
        else if(qFound && !pFound)
        {
            if (root.val == p.val)
            {
                pFound = true;
            }
            else if (root.val > p.val)
            {
                LowestCommonAncestor(root.left, p, q);
            }
            else
            {
                LowestCommonAncestor(root.right, p, q);
            } 
        }
        else if(!pFound && !qFound)
        {
            if (root.val > p.val && root.val > q.val)
            {
                LowestCommonAncestor(root.left, p, q);
            }
            else if (root.val < q.val && root.val < p.val)
            {
                LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                if (LCA == null)
                {
                    LCA = root;
                }
                
                LowestCommonAncestor(root.left, p, q);
                LowestCommonAncestor(root.right, p, q);
            }
        }
        return LCA;
    }
}
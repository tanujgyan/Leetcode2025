namespace TreeGemini;

public class _100
{
    private bool isSame = true;
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (isSame)
        {
            if (p != null && q != null && isSame)
            {
                IsSameTree(p.left, q.left);
                IsSameTree(p.right, q.right);
                if (p.val != q.val && isSame)
                {
                    isSame = false;
                    return false;
                } 
                
                if (isSame && p.val == q.val)
                {
                    return true;
                }
            }
            else if (p == null && q != null && isSame)
            {
                isSame = false;
                return false;
            }
            else if (p != null && q == null && isSame)

            {
                isSame = false;
                return false;
            }
            else if(p == null && q == null && isSame)
            {
                return true;
            }
        }

        return isSame;
    }
}
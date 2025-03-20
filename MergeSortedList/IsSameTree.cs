namespace LeetCode;

public class IsSameTree
{
    public bool result = true;
    public bool Traverse(TreeNode p, TreeNode q)
    {
        if (result == false)
        {
            return result;
        }

        if (p == null && q != null)
        {
            result = false;
            return result;
        }
        else if (p != null && q == null)
        {
            result = false;
            return result;
        }

        if (p == null || q == null) return result;
        if (p.val != q.val)
        {
            result = false;
            return result;
        }
        else
        {
            Traverse(p.left, q.left);
            Traverse(p.right, q.right);
        }

        return result;
    }
}
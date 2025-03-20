using System.Reflection.Metadata;

namespace TreeGemini;

public class _98
{
    private List<int> list = new List<int>();
    public bool IsValidBST(TreeNode root)
    {
        Inorder(root);
        return list.Distinct().Count() == list.Count() && list.SequenceEqual(list.OrderBy(x => x));        
    }

    private TreeNode Inorder(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }
        IsValidBST(root.left);
        list.Add(root.val);
        IsValidBST(root.right);
        return root;
    }

}
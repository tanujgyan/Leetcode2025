namespace TreeGemini;

public class _701
{
    
    public TreeNode InsertIntoBST(TreeNode root, int val) {
      TreeNode returnRoot = new TreeNode();
      returnRoot = root;
      if (root == null)
      {
        return new TreeNode(val);
      }
      InsertPosition(root, val);
      return returnRoot;
    }

    private void InsertPosition(TreeNode root, int val)
    {
        
        if (root.left == null && root.right == null)
        {
            if (val>root.val)
            {
                root.right = new TreeNode(val);
            }
            else
            {
                root.left = new TreeNode(val);
            }

            return;
        }

        
        if (val > root.val)
        {
            if (root.right != null)
            {
                InsertPosition(root.right, val);
            }
            else
            {
                root.right = new TreeNode(val);
            }
            
            
        }
        else if (val < root.val)
        {
            if (root.left != null)
            {
                InsertPosition(root.left, val);
            }
            else
            {
                root.left = new TreeNode(val);
            }
           
        }
        
    }
}
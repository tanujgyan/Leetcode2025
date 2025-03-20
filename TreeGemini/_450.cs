using System.Xml;

namespace TreeGemini;

public class _450
{
   
    public TreeNode DeleteNode(TreeNode root, int key)
    { 
        TreeNode rootPointer = root;
        TreeNode currentPointer = root;
        if ( root==null)
        {
            return null;
        }

        if (root.val == key)
        {
            if (root.left == null)
            {
                return root.right;
            }

            if (root.right == null)
            {
                return root.left;
            }
            
        }
       
        
        DeleteTheNode(ref currentPointer, key);

        
        return rootPointer;
    }

    private TreeNode DeleteTheNode(ref TreeNode currentPointer, int key)
    {
        
        if (currentPointer == null)
        {
            return currentPointer;
        }

        if (currentPointer.left == null && currentPointer.right == null && currentPointer.val == key)
        {
            currentPointer = null;
            return currentPointer;
        }
        
        else if (currentPointer.left == null && currentPointer.right != null && currentPointer.val == key)
        {
            currentPointer = currentPointer.right;
            
        }
        else if (currentPointer.left !=null && currentPointer.val == key)
        {
           
            var ino  = InOrderPredecessor(currentPointer.left);
            currentPointer.val = ino.val;
            DeleteTheNode(ref currentPointer.left, ino.val);
        }
        else if (key > currentPointer.val)
        {
            return DeleteTheNode(ref currentPointer.right, key);
        }
        else if (key < currentPointer.val)
        {
            return DeleteTheNode(ref currentPointer.left, key);
        }
        
        return currentPointer;
    }

    private TreeNode InOrderPredecessor( TreeNode root)
    {
        if (root.right != null)
        {
            return InOrderPredecessor( root.right);
        }

        return root;
    }
}

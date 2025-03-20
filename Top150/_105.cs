using TreeGemini;

namespace Top150;

public class _105
{
  
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0)
        {
            return null;
        }
    
        if (preorder.Length == 1)
        {
            return new TreeNode(preorder[0]);
        }
        int rootVal = preorder[0];
        int rootIndex = Array.IndexOf(inorder, rootVal);
        int[] leftInorder = inorder[0..(rootIndex)];
        int[] rightInorder = inorder[(rootIndex + 1)..inorder.Length];
        int[] leftPreorder = preorder[1..(leftInorder.Length+1)];
        int[] rightPreorder = preorder[(leftInorder.Length + 1)..preorder.Length];
        return new TreeNode(rootVal, BuildTree(leftPreorder, leftInorder), BuildTree(rightPreorder, rightInorder));
    }
}
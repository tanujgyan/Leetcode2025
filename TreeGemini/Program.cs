namespace TreeGemini;

class Program
{
    static void Main(string[] args)
    {
        _110 _110 = new _110();
        var root = ArrayToTreeNode([1,2,2,3,3,null,null,4,4]);
        _110.IsBalanced(root);
    }
    static TreeNode ArrayToTreeNode(int?[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return null;
        }

        TreeNode root = CreateNode(arr, 0);
        return root;
    }

    static TreeNode CreateNode(int?[] arr, int index)
    {
        if (index >= arr.Length || arr[index] == null)
        {
            return null;
        }

        TreeNode node = new TreeNode(arr[index].Value);
        node.left = CreateNode(arr, 2 * index + 1);
        node.right = CreateNode(arr, 2 * index + 2);

        return node;
    }
}
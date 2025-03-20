namespace TreeGemini;

public class _102
{
   
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
     var queue = new Queue<TreeNode>();
     IList<IList<int>> result = [];
        var level = 0;
        if (root == null)
        {
            return [];
        }
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            List<int> levelList = new List<int>();
            var currentQueueCount = queue.Count;
            for (int i = 0; i < currentQueueCount; i++)
            {
                var node = queue.Dequeue();
                levelList.Add(node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            result.Add(levelList);
        }

        return result;
    }
}
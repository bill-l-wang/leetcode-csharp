using System.Collections.Generic;

namespace LeetCode.Tree
{
    public class DeserializeBinaryTree
    {
        public TreeNode Deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
                return null;

            var queue = new Queue<TreeNode>();
            var nodes = data.Split(' ');
            var root = new TreeNode(int.Parse(nodes[0]));
            queue.Enqueue(root);

            for (var i = 1; i < nodes.Length; i++)
            {
                var parent = queue.Dequeue();
                if (nodes[i] != "n")
                {
                    var left = new TreeNode(int.Parse(nodes[i]));
                    parent.Left = left;
                    queue.Enqueue(left);
                }

                if (nodes[++i] != "n")
                {
                    var right = new TreeNode(int.Parse(nodes[i]));
                    parent.Right = right;
                    queue.Enqueue(right);
                }
            }

            return root;
        }
    }
}

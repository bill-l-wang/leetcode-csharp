using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/serialize-and-deserialize-binary-tree/description/
    /// </summary>
    public class SerializeBinaryTree
    {
        public string Serialize(TreeNode root)
        {
            if (root == null)
                return string.Empty;

            var sb = new StringBuilder();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    sb.Append("n ");
                    continue;
                }
                sb.Append($"{node.Val} ");
                queue.Enqueue(node.Left);
                queue.Enqueue(node.Right);
            }

            return sb.ToString();
        }
    }
}

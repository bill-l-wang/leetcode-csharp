using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Tree
{
    public class PreorderTraversal
    {
        public IEnumerable<int> Preorder(TreeNode root)
        {
            if(root == null)
                return Enumerable.Empty<int>();

            var results = new List<int>();
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node != null)
                {
                    results.Add(node.Val);
                    stack.Push(node.Right);
                    stack.Push(node.Left);
                }
            }

            return results;
        }
    }
}

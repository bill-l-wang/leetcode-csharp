using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Tree
{
    public class InorderTraversal
    {
        public IEnumerable<int> Traverse(TreeNode root)
        {
            if(root == null)
                return Enumerable.Empty<int>();

            var results = new List<int> {root.Val};
            var stack = new Stack<TreeNode>();
            var current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                current = stack.Pop();
                results.Add(current.Val);
                current = current.Right;
            }

            return results;
        }
    }
}
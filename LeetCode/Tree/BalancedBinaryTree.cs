using System;

namespace LeetCode.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/balanced-binary-tree/description/
    /// a binary tree in which the depth of the two subtrees of every node never differ by more than 1
    /// </summary>
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            return GetDepth(root) != -1;
        }

        private static int GetDepth(TreeNode node)
        {
            if (node == null)
                return 0;

            var leftDepth = GetDepth(node.Left);
            if (leftDepth == -1)
                return -1;

            var rightDepth = GetDepth(node.Right);
            if (rightDepth == -1)
                return -1;

            if (leftDepth - rightDepth < -1 || leftDepth - rightDepth > 1)
                return -1;

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}

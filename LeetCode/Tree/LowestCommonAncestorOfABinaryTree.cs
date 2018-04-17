namespace LeetCode.Tree
{
    public class LowestCommonAncestorOfABinaryTree
    {
        public TreeNode GetLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null)
                return root;

            if (root == p || root == q)
                return root;

            var left = GetLowestCommonAncestor(root.Left, p, q);
            var right = GetLowestCommonAncestor(root.Right, p, q);

            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
                return root;
        }
    }
}

namespace LeetCode.Tree
{
    public class LowestCommonAncestorOfBinarySearchTree
    {
        public TreeNode GetLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while ((root.Val - p.Val) * (root.Val - q.Val) > 0)
            {
                root = p.Val < root.Val ? root.Left : root.Right;
            }

            return root;
        }
    }
}

namespace LeetCode.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/description/
    /// Given
    ///   1
    ///  /  \
    ///  2   5
    /// / \   \
    /// 3  4   6
    /// then return
    ///  1
    ///   \
    ///    2
    ///     \
    ///      3
    ///       \
    ///        4
    ///         \
    ///          5
    ///           \
    ///            6
    /// </summary>
    public class FlattenBinaryTree
    {
        private TreeNode _prev;

        public void Flatten(TreeNode root)
        {
            if(root == null)
                return;

            Flatten(root.Right);
            Flatten(root.Left);

            root.Right = _prev;
            root.Left = null;
            _prev = root;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
    public class CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;

            int leftDepth = GetDepth(root.left);
            int rightDepth = GetDepth(root.right);

            if (leftDepth == rightDepth)
            {
                return (1 << leftDepth) + CountNodes(root.right);
            }
            else
            {
                return (1 << rightDepth) + CountNodes(root.left);
            }

        }
        private int GetDepth(TreeNode node)
        {
            int depth = 0;
            while (node != null)
            {
                depth++;
                node = node.left;
            }
            return depth;
        }
    }
}

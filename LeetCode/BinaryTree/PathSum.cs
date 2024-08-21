using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if(root == null) return false;
            if(root.left == null && root.right == null)
            {
                return root.val == targetSum;
            }
            int sum = targetSum - root.val;

            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }
    }
}

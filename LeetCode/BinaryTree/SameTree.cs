using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
    public class TreeNode1
    {
        public int val;
        public TreeNode1 left;
        public TreeNode1 right;
        public TreeNode1(int val = 0, TreeNode1 left = null, TreeNode1 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class SameTree
    {
        public bool IsSameTree(TreeNode1 p, TreeNode1 q)
        {
            if (p == null ^ q == null)
            {
                return false;
            }
            if (p == null && q == null)
            {
                return true;
            }
            if (p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}

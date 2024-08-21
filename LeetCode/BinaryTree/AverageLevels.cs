using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
    public class AverageLevels
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                double levelSum = 0;

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    levelSum += node.val;

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                double levelAverage = levelSum / levelSize;
                result.Add(levelAverage);
            }
            return result;
        }
    }
}


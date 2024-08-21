using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree.Tests
{
    [TestClass()]
    public class PathSumTests
    {
        [TestMethod]
        public void TestHasPathSum_True()
        {
            // Arrange
            var root = new TreeNode(5,
                new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2)), null),
                new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)))
            );
            var solution = new PathSum();

            // Act
            var result = solution.HasPathSum(root, 22);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestHasPathSum_False()
        {
            // Arrange
            var root = new TreeNode(1,
                new TreeNode(2),
                new TreeNode(3)
            );
            var solution = new PathSum();

            // Act
            var result = solution.HasPathSum(root, 5);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestHasPathSum_EmptyTree()
        {
            // Arrange
            TreeNode root = null;
            var solution = new PathSum();

            // Act
            var result = solution.HasPathSum(root, 0);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
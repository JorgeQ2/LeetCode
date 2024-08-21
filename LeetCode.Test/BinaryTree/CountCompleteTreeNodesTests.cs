using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestCountNodes_CompleteTree()
        {
            // Arrange
            var root = new TreeNode(1,
                new TreeNode(2, new TreeNode(4), new TreeNode(5)),
                new TreeNode(3, new TreeNode(6), null)
            );
            var solution = new CountCompleteTreeNodes();

            // Act
            var result = solution.CountNodes(root);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestCountNodes_EmptyTree()
        {
            // Arrange
            TreeNode root = null;
            var solution = new CountCompleteTreeNodes();

            // Act
            var result = solution.CountNodes(root);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCountNodes_SingleNodeTree()
        {
            // Arrange
            var root = new TreeNode(1);
            var solution = new CountCompleteTreeNodes();

            // Act
            var result = solution.CountNodes(root);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
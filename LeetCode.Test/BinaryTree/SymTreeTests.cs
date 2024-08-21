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
    public class SymTreeTests
    {
        [TestMethod]
        public void TestSymmetricTree()
        {
            // Arrange
            var root = new TreeNode(1,
                new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(4), new TreeNode(3))
            );
            var symTree = new SymTree();

            // Act
            var result = symTree.IsSymmetric(root);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNonSymmetricTree()
        {
            // Arrange
            var root = new TreeNode(1,
                new TreeNode(2, null, new TreeNode(3)),
                new TreeNode(2, null, new TreeNode(3))
            );
            var symTree = new SymTree();

            // Act
            var result = symTree.IsSymmetric(root);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestSingleElementTree()
        {
            // Arrange
            var root = new TreeNode(1);
            var symTree = new SymTree();

            // Act
            var result = symTree.IsSymmetric(root);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
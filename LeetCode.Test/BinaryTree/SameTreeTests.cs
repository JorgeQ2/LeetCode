﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree.Tests
{
    [TestClass]
    public class SolutionTests1
    {
        [TestMethod]
        public void IsSameTree_Test1()
        {
            // Arrange
            var solution = new SameTree();
            var p = new TreeNode1(1) { left = new TreeNode1(2), right = new TreeNode1(3) };
            var q = new TreeNode1(1) { left = new TreeNode1(2), right = new TreeNode1(3) };

            // Act
            bool result = solution.IsSameTree(p, q);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSameTree_Test2()
        {
            // Arrange
            var solution = new SameTree();
            var p = new TreeNode1(1) { left = new TreeNode1(2) };
            var q = new TreeNode1(1) { right = new TreeNode1(2) };

            // Act
            bool result = solution.IsSameTree(p, q);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSameTree_Test3()
        {
            // Arrange
            var solution = new SameTree();
            var p = new TreeNode1(1) { left = new TreeNode1(2), right = new TreeNode1(1) };
            var q = new TreeNode1(1) { left = new TreeNode1(1), right = new TreeNode1(2) };

            // Act
            bool result = solution.IsSameTree(p, q);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

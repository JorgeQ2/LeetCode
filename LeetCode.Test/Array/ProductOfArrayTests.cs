using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.Tests
{
    [TestClass]
    public class ProductOfArrayTests
    {
        [TestMethod]
        public void TestProductExceptSelf_WithPositiveNumbers()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int[] expected = { 24, 12, 8, 6 };
            ProductOfArray productOfArray = new ProductOfArray();

            // Act
            int[] result = productOfArray.ProductExceptSelf(nums);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestProductExceptSelf_WithZero()
        {
            // Arrange
            int[] nums = { -1, 1, 0, -3, 3 };
            int[] expected = { 0, 0, 9, 0, 0 };
            ProductOfArray productOfArray = new ProductOfArray();

            // Act
            int[] result = productOfArray.ProductExceptSelf(nums);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestProductExceptSelf_WithSingleElement()
        {
            // Arrange
            int[] nums = { 5 };
            int[] expected = { 1 };
            ProductOfArray productOfArray = new ProductOfArray();

            // Act
            int[] result = productOfArray.ProductExceptSelf(nums);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
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
    public class RandomizedSetTests
    {
        [TestMethod]
        public void TestInsert()
        {
            // Arrange
            var randomizedSet = new RandomizedSet();

            // Act & Assert
            Assert.IsTrue(randomizedSet.Insert(1)); // Insert 1, should return true
            Assert.IsFalse(randomizedSet.Insert(1)); // Insert 1 again, should return false
        }

        [TestMethod]
        public void TestRemove()
        {
            // Arrange
            var randomizedSet = new RandomizedSet();
            randomizedSet.Insert(1);

            // Act & Assert
            Assert.IsTrue(randomizedSet.Remove(1)); // Remove 1, should return true
            Assert.IsFalse(randomizedSet.Remove(1)); // Remove 1 again, should return false
        }

        [TestMethod]
        public void TestGetRandom()
        {
            // Arrange
            var randomizedSet = new RandomizedSet();
            randomizedSet.Insert(1);
            randomizedSet.Insert(2);
            randomizedSet.Insert(3);

            // Act
            int randomValue = randomizedSet.GetRandom();

            // Assert
            Assert.IsTrue(randomValue == 1 || randomValue == 2 || randomValue == 3); // Random value should be one of the inserted values
        }
    }
}

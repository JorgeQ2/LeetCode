using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.WorkingArry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkingArry.Tests
{
    [TestClass]
    public class ResearcherTests
    {
        [TestMethod]
        public void TestCalculateHIndex_Example1()
        {
            // Arrange
            var researcher = new H_Index();
            int[] citations = { 3, 0, 6, 1, 5 };
            int expected = 3;

            // Act
            int actual = researcher.HIndex(citations);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculateHIndex_Example2()
        {
            // Arrange
            var researcher = new H_Index();
            int[] citations = { 1, 3, 1 };
            int expected = 1;

            // Act
            int actual = researcher.HIndex(citations);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
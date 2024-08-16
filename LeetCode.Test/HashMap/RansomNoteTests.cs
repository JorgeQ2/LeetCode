using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.HashMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap.Tests
{
    [TestClass()]
    public class RansomNoteTests
    {
        [TestMethod]
        public void TestCanConstruct_ValidCase1()
        {
            // Arrange
            var solution = new RansomNote();
            string ransomNote = "a";
            string magazine = "b";

            // Act
            bool result = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCanConstruct_ValidCase2()
        {
            // Arrange
            var solution = new RansomNote();
            string ransomNote = "aa";
            string magazine = "ab";

            // Act
            bool result = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCanConstruct_ValidCase3()
        {
            // Arrange
            var solution = new RansomNote();
            string ransomNote = "aa";
            string magazine = "aab";

            // Act
            bool result = solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
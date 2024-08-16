using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.TwoPointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointer.Tests
{
    [TestClass()]
    public class SubsequenceTests
    {
        [TestMethod]
        public void TestValidSubsequence()
        {
            // Arrange
            var subsequence = new Subsequence();
            string s = "abc";
            string t = "abssfc";

            // Act
            bool result = subsequence.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestInvalidSubsequence()
        {
            // Arrange
            var subsequence = new Subsequence();
            string s = "axc";
            string t = "ahbgdc";

            // Act
            bool result = subsequence.IsSubsequence(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestEmptySubsequence()
        {
            // Arrange
            var subsequence = new Subsequence();
            string s = "";
            string t = "ahbgdc";

            // Act
            bool result = subsequence.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
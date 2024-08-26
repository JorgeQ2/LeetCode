using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Bit.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestAddBinary_SimpleCase()
        {
            // Arrange
            var solution = new AddBinary1();
            string a = "11";
            string b = "1";

            // Act
            string result = solution.AddBinary(a, b);

            // Assert
            Assert.AreEqual("100", result);
        }

        [TestMethod]
        public void TestAddBinary_ComplexCase()
        {
            // Arrange
            var solution = new AddBinary1();
            string a = "1010";
            string b = "1011";

            // Act
            string result = solution.AddBinary(a, b);

            // Assert
            Assert.AreEqual("10101", result);
        }

        [TestMethod]
        public void TestAddBinary_EmptyStrings()
        {
            // Arrange
            var solution = new AddBinary1();
            string a = "";
            string b = "";

            // Act
            string result = solution.AddBinary(a, b);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestAddBinary_OneEmptyString()
        {
            // Arrange
            var solution = new AddBinary1();
            string a = "1010";
            string b = "";

            // Act
            string result = solution.AddBinary(a, b);

            // Assert
            Assert.AreEqual("1010", result);
        }
    }
}
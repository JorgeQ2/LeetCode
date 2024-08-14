using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass()]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void TestRomanToInt_Case1()
        {
            // Arrange
            var converter = new RomanNumerals();
            string roman = "III";

            // Act
            int result = converter.RomanToInt(roman);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestRomanToInt_Case2()
        {
            // Arrange
            var converter = new RomanToInteger();
            string roman = "LVIII";

            // Act
            int result = converter.RomanToInt(roman);

            // Assert
            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void TestRomanToInt_Case3()
        {
            // Arrange
            var converter = new RomanToInteger();
            string roman = "MCMXCIV";

            // Act
            int result = converter.RomanToInt(roman);

            // Assert
            Assert.AreEqual(1994, result);
        }
    }
}
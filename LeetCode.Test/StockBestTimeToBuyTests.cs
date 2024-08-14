using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass()]
    public class StockBestTimeToBuyTests
    {
        [TestMethod]
        public void TestMaxProfit_Case1()
        {
            // Arrange
            var stock = new StockBestTimeToBuy();
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            // Act
            int result = stock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMaxProfit_Case2()
        {
            // Arrange
            var stock = new StockBestTimeToBuy();
            int[] prices = { 7, 6, 4, 3, 1 };

            // Act
            int result = stock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMaxProfit_Case3()
        {
            // Arrange
            var stock = new StockBestTimeToBuy();
            int[] prices = { 2, 4, 1 };

            // Act
            int result = stock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
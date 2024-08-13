using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class RemoveDupsTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            //arrange
            var RemoveDups = new RemoveDups();
            int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
            int expectedUniqueCount = 5;
            int[] expectedNums = { 1, 2, 3, 4, 5 };

            // Act
            int uniqueCount = RemoveDups.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedUniqueCount, uniqueCount);
            for (int i = 0; i < expectedUniqueCount; i++)
            {
                Assert.AreEqual(expectedNums[i], nums[i]);
            }
        }

    }
}
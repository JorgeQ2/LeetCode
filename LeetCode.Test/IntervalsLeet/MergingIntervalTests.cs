using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.IntervalsLeet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.IntervalsLeet.Tests
{
    [TestClass()]
    public class MergingIntervalTests
    {
       
        [TestMethod]
        public void Merge_NoIntervals_ReturnsEmptyArray()
        {
            // Arrange
            var mergingInterval = new MergingInterval();
            int[][] intervals = new int[][] { };
            int[][] expected = new int[][] { };

            // Act
            var result = mergingInterval.Merge(intervals);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
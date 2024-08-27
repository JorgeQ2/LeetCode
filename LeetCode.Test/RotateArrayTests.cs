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
    public class RotateArrayTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            int[] input = [1, 2, 3, 4, 5, 6, 7];
            int[] expected = [5, 6, 7, 1, 2, 3, 4];
            int k = 3;
            new RotateArray().Rotate(input, k);
            CollectionAssert.AreEqual(input, expected);
        }
    }
}
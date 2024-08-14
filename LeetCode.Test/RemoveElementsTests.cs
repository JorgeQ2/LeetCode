using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass()]
    public class RemoveElementsTests
    {

        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] nums = [3, 2, 2, 3];
            int[] expected = [2, 2];
            int val = 3;
            RemoveElements leet = new();
            int k = leet.RemoveElement(nums, val);
            Array.Sort(nums, 0, k);
            Assert.AreEqual(2, k);

            CollectionAssert.AreEqual(nums[0..k], expected);
        }
    }
}
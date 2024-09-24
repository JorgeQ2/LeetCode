using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix.Tests
{
    [TestClass()]
    public class ValidSudokuTests
    {
        [TestMethod]
        public void TestIsValidSudoku()
        {
            var solution = new ValidSudoku();

            char[][] board = new char[][]
            {
            new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            bool result = solution.IsValidSudoku(board);

            Assert.IsTrue(result);
        }
    }
}
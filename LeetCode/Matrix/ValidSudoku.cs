using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char current_val = board[i][j];

                    if (current_val != '.')
                    {
                        if (!seen.Add(current_val + "found in row" + i) ||
                           !seen.Add(current_val + "found in column" + j) ||
                           !seen.Add(current_val + "found in subbox" + i / 3 + "-" + j / 3))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}

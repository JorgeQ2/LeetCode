using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.IntervalsLeet
{
    public class InsetInterval
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, new Comparison<int[]>(
                  (x, y) => { return x[0] - y[0]; })); //sort so its in ascending order

            List<int[]> result = new(); //list to keep the result
            for (int i = 0; i < intervals.Length; i++) // go through each pair in the array
            {
                if (i == intervals.Length - 1) //If the current interval is the last one, it is directly added to the result
                {
                    result.Add(intervals[i]);
                }
                else
                {
                    if (intervals[i + 1][0] >= intervals[i][0] && intervals[i + 1][0] <= intervals[i][1])
                    //does the current array item overlaps next array item?
                    {
                        intervals[i + 1][0] = Math.Min(intervals[i][0], intervals[i + 1][0]);
                        intervals[i + 1][1] = Math.Max(intervals[i][1], intervals[i + 1][1]);
                        //expand the next array item to include both current and next item ex [1,3] [2,6] turns into [1,6]
                    }
                    else  //if next item is not overlapping with current item, we should add the current item to
                          // result list ex: [1,6] and [8,10] so it just adds them to the result
                    { result.Add(intervals[i]); }
                }
            }
            return result.ToArray();//covert List to int array ex:[1, 3], [2, 6], [8, 10], [15, 18], [5, 12]
        }

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> newIntervals = new List<int[]>(intervals);
            newIntervals.Add(newInterval);//[1, 12], [15, 18]
            return Merge(newIntervals.ToArray()); //[1, 12], [15, 18]
        }
    }
}

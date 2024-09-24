﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.IntervalsLeet
{
    public class MergingInterval
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0) return new int[0][];

            Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

            List<int[]> merged = new List<int[]>();
            int[] currentInterval = intervals[0];
            merged.Add(currentInterval);

            foreach (var interval in intervals)
            {
                int currentEnd = currentInterval[1];
                int nextStart = interval[0];
                int nextEnd = interval[1];

                if (currentEnd <= nextStart)
                {
                    currentInterval[1] = Math.Max(currentEnd, nextStart);

                }
                else
                {
                    currentInterval = interval;
                    merged.Add(currentInterval);
                }

            }
            return merged.ToArray();
        }
    }
}

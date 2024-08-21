using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Day1
{
    public class StockBestTimeToBuy
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {

                if (price < minPrice)
                {
                    minPrice = price;
                }
                else if (price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }

            }
            return maxProfit;

        }
        public int MinProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int maxPrice = int.MinValue;
            int minProfit = int.MaxValue;

            foreach (int price in prices)
            {
                if (price > maxPrice)
                {
                    maxPrice = price;
                }
                else if (price - maxPrice < minProfit)
                {
                    minProfit = price - maxPrice;
                }
            }

            return minProfit;


        }
    }
}

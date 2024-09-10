using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkingArry
{
    public class RandomizedSet
    {
        private Dictionary<int, int> dict; //store value of idx
        private List<int> list; //storing values
        private Random rand; //generate
        
        public RandomizedSet()
        {
            //initialize constructors
            dict = new Dictionary<int, int>();
            list = new List<int>();
            rand = new Random();

        }

        public bool Insert(int val)
        {
            //if value is present return false
            if (dict.ContainsKey(val))
            {
                return false;
            }
            else //if not present add to list
            {
                list.Add(val);
                dict[val] = list.Count - 1; //storing value in dict and its index
                return true;

            }
        }

        public bool Remove(int val)
        {
            if (!dict.TryGetValue(val, out int idx)) //if val not present return false
            {
                return false;
            }
            int lastElement = list[list.Count - 1]; //get last element
            list[idx] = lastElement; //replacing element removing with last element in the list
            dict[lastElement] = idx;// updates dict wih last element

            list.RemoveAt(list.Count - 1); //remove last element from dict and list  
            dict.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            // generate random
            int randomIndex = rand.Next(list.Count);
            return list[randomIndex];

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Cache
{
    public class LRUCache
    {
        private int capacity;
        private Dictionary<int, LinkedListNode<(int key, int value)>> cache;
        private LinkedList<(int key, int value)> lruList;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
            lruList = new LinkedList<(int key, int value)>();

        }

        public int Get(int key)
        {
            if (cache.ContainsKey(key))
            {
                var node = cache[key];
                lruList.Remove(node);
                lruList.AddFirst(node);
                return node.Value.value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (cache.ContainsKey(key))
            {
                var node = cache[key];
                lruList.Remove(node);
                node.Value = (key, value);
                lruList.AddFirst(node);
            }
            else
            {
                if (cache.Count >= capacity)
                {
                    var lru = lruList.Last;
                    cache.Remove(lru.Value.key);
                    lruList.RemoveLast();
                }
                var newNode = new LinkedListNode<(int key, int value)>((key, value));
                lruList.AddFirst(newNode);
                cache[key] = newNode;

            }
        }
    }
}
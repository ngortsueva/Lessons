using System;
using System.Collections;
using System.Collections.Generic;

namespace ex_total
{
    public class MovingTotal
    {
        private List<int> all;
        private List<int> totalList;

        public MovingTotal()
        {
            all = new List<int>();
            totalList = new List<int>();
        }

        public void Append(int[] list)
        {
            int index;
            if (all.Count == 0) index = 0;
            else index = list.Length;

            all.AddRange(list);

            int total = 0;

            for(int i = index; i < all.Count; i++)
            {
                total += Convert.ToInt32(all[i]);
            }
            totalList.Add(total);
        }

        public bool Contains(int total)
        {
            return totalList.Contains(total);
            
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            MovingTotal movingTotal = new MovingTotal();

            movingTotal.Append(new int[] { 1, 2, 3 });

            Console.WriteLine(movingTotal.Contains(6));
            Console.WriteLine(movingTotal.Contains(9));

            movingTotal.Append(new int[] { 4 });

            Console.WriteLine(movingTotal.Contains(9));
        }
    }
}

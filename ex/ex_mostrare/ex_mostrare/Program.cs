using System;
using System.Linq;
using System.Collections.Generic;

namespace ex_mostrare
{
    class Rare
    {
        public int NthMostRare(int[] elements, int n)
        {
            int cur;
            int total;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < elements.Length; i++)
            {
                cur = elements[i];

                if (dict.Keys.Contains(cur)) continue;

                total = 0;

                for (int j = 0; j < elements.Length; j++)
                {
                    if (cur == elements[j]) total++;
                }
                if(!dict.Keys.Contains(cur)) dict.Add(cur, total);
            }
            return dict.FirstOrDefault(v => v.Key == n).Value;
            //var element = from entry in dict where entry.Value == n select entry;

            //return 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rare rare = new Rare();

            int x = rare.NthMostRare(new int[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 5, 4, 3, 5, 4, 5 }, 5);

            Console.WriteLine(x);
        }
    }
}

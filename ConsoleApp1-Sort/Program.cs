using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] boxList = new string[]
            {
                "jog",
                "34",
                "alps",
                "45"
            };

            string[] boxList2 = new string[]
            {
                "mi2 jog mid pet",
                "wz3 34 54 398",
                "a1 alps cow bar",
                "x4 45 21 8"
            };
            List<string> list = orderedJunctionBoxes(4, boxList2);

            foreach (var str in list)
                System.Console.WriteLine(str);

            Console.ReadKey();
        }

        public static List<string> orderedJunctionBoxes(int numberOfBoxes,
                                             string[] boxList)
        {
            string temp = "";

            // WRITE YOUR CODE HERE
            for (int i = 0; i < boxList.Length - 1; i++)
            {

                for (int j = i + 1; j < boxList.Length; j++)
                {

                    if (Compare(boxList[i].Split(" ")[1], boxList[j].Split(" ")[1]) > 0)
                    {
                        temp = boxList[i];
                        boxList[i] = boxList[j];
                        boxList[j] = temp;
                    }
                }
            }
            List<string> boxListRes = new List<string>(boxList);

            return boxListRes;
        }

        public static int Compare(string x, string y)
        {
            
            if (x == null) return -1;
            if (y == null) return 1;

            int i = 0;
            int length = x.Length <= y.Length ? x.Length : y.Length;

            int n1 = 0; int n2 = 0;
            bool isNumeric1 = int.TryParse(x, out n1);
            bool isNumeric2 = int.TryParse(y, out n1);
            if (isNumeric1 && isNumeric2)
            {
                if (n1 > n2) return -1;
                else return 1;
            }
            if (isNumeric1) return 1;
            if (isNumeric2) return -1;

            while (i < length)
            {
                if (x[i] > y[i]) return 1;
                if (x[i] < y[i]) return -1;
                i++;
            }

            return 0;
        }
    }
}

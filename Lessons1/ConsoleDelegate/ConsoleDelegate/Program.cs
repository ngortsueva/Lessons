/* Пример работы с делегатами
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    public delegate int BinaryOp(int x, int y);
    public class SimpleMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void DisplayDelegateIndo(Delegate delObj)
        {
            Console.WriteLine("Method name: {0}", delObj.Method);
            Console.WriteLine("Type name: {0}", delObj.Target);
        }

        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            BinaryOp binop = new BinaryOp(m.Add);

            Console.WriteLine("10 + 10 is {0}", binop(10, 10));

            DisplayDelegateIndo(binop);

            Console.ReadLine();
        }
    }
}

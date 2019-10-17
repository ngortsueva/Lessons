using System;
using System.IO;

namespace ConsoleApp1_aspose
{
    class Program
    {
        static void Main(string[] args)
        {
            Keypad keypad = new Keypad();

            Console.Write("Input number: ");

            string num = Console.ReadLine();

            Console.WriteLine(keypad.Convert(num));
        }
    }
}

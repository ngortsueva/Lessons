using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public string name;
        public Car()
        {
            name = "";
        }

        public string Name { get { return name; } set { name = value; } }

        public void Print()
        {
            Console.WriteLine(name);
        }
    }
}

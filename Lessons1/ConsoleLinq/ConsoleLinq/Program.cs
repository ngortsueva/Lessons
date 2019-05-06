/* Пример работы с LINQ
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        public bool IsDead { get { return carIsDead; } set { carIsDead = false; } }

        private bool carIsDead;
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxsp, int cursp)
        {
            PetName = name;
            MaxSpeed = maxsp;
            CurrentSpeed = cursp;
        }
    }
    class Program
    {
        public static void QueryOverStrings()
        {
            string[] curGames = { "Startrek", "Fallow 3", "System Shock 2", "Morrowind", "Counter Strike" };

            IEnumerable<string> subset = from game in curGames where game.Contains(" ") orderby game select game;

            foreach (string str in subset) Console.WriteLine(str);
        }

        public static void QueryOverInt()
        {
            int[] nums = { 10, 20, 30, 40, 1, 2, 3, 8 };

            IEnumerable<int> subset = from i in nums where i < 10 select i;

            foreach (int i in subset) Console.WriteLine("Item: {0}", i);
        }

        public static void ImmediateExec()
        {
            int[] nums = { 10, 20, 30, 40, 1, 2, 3, 8 };

            List<int> subset = (from i in nums where i < 10 select i).ToList<int>();

            foreach (int i in subset) Console.WriteLine("Item: {0}", i);
        }

        public static void GetFastCars(List<Car>  myCars)
        {
            var fastCars = from c in myCars where c.MaxSpeed < 60 orderby c.MaxSpeed descending select c;

            foreach (Car car in fastCars) Console.WriteLine("Car: {0}, speed = {1}", car.PetName, car.MaxSpeed);
        }

        static void Main(string[] args)
        {
            QueryOverStrings();

            Console.WriteLine("");

            QueryOverInt();

            Console.WriteLine("");

            ImmediateExec();

            Console.WriteLine("");

            List<Car> myCars = new List<Car>() {
                new Car( "Henry", 60, 30), 
                new Car( "Daisy", 70, 30),
                new Car( "Joe", 40, 20),
                new Car( "Joe-2", 50, 20),
                new Car( "Joe-3", 45, 20)
            };

            GetFastCars(myCars);

            //Пример работы с Except 
            List<string> myCars2 = new List<string> { "Yugo", "BMW", "Aztec" };
            List<string> myCars3 = new List<string> { "Saab", "BMW", "Aztec" };

            //Выборка из myCars2 только тех элементов, которых нет в myCars3
            var carExcept = (from c in myCars2 select c).Except(from c2 in myCars3 select c2);

            Console.Write("Except set:    ");

            foreach (string s in carExcept) Console.Write("{0}", s);

            //Пример работы с Intersect - выборка из myCars2 только тех элементов, которые есть в обоих списках
            var carIntersect = (from c in myCars2 select c).Intersect(from c2 in myCars3 select c2);

            Console.Write("\nIntersect set: ");

            foreach (string s in carIntersect) Console.Write("{0}, ", s);

            //Пример работы с Union (объединение без повторяющихся элементов)
            var carUnion = (from c in myCars2 select c).Union(from c2 in myCars3 select c2);

            Console.Write("\nUnion set:     ");

            foreach (string s in carUnion) Console.Write("{0}, ", s);

            //Пример работы с Concat (простое объединение всех элементов)
            var carConcat = (from c in myCars2 select c).Concat(from c2 in myCars3 select c2);

            Console.Write("\nConcat set:    ");

            foreach (string s in carConcat) Console.Write("{0}, ", s);

            //Пример работы с Concat (простое объединение всех элементов) с удалением повторяющихся элементов с помощью процедуры Distinct()
            Console.Write("\nDistinct set:  "); foreach (string s in carConcat.Distinct()) Console.Write("{0}, ", s);

            Console.ReadLine();
        }
    }
}

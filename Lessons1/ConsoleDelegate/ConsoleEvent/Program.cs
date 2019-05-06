/* Пример работы с событиями (используется ключевое слово event)
 * 
 * Сперва создается делегат. Затем с ключевым словом event определяются объекты-делегаты
 * 
 * Ключевое слово event упрощает написание кода: не нужно дополнительно создавать процедуры регистрации обработчика Regist
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEvent
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

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded != null) Exploded("Car is dead");
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && AboutToBlow != null)

                    AboutToBlow("Warning: Predel speed!");

                if (CurrentSpeed >= MaxSpeed)

                    carIsDead = true;

                else Console.WriteLine("Current speed is {0}", CurrentSpeed);
            }
        }


        public delegate void CarEngineHandler(string message); //Определение делегата
        
        public event CarEngineHandler Exploded;     //Определение собыимя
        public event CarEngineHandler AboutToBlow;  //Еще одно событие
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("car1", 100, 10);

            car1.Exploded += OnExploded;
            car1.AboutToBlow += OnAboutToBlow;

            for (int i = 0; i < 6; i++)

                car1.Accelerate(20);

            Console.ReadLine();
        }
        public static void OnExploded(string message)
        {
            Console.WriteLine("****Message from Car object (proc OnExploded):");

            Console.WriteLine(message);
        }

        public static void OnAboutToBlow(string message)
        {
            Console.WriteLine("****Message from Car object (proc OnAboutToBlow):");

            Console.WriteLine(message);
        }
    }
}

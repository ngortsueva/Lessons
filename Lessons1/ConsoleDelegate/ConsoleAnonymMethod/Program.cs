/* Пример работы с делегатами
 * 
 * Данный пример показывает применение Анонимных методов - когда вместо указания процедуры обратного вызова (и её дальнейшего определния в коде)
 * сразу определяется делегат с телом той самой процедуры, но без имени.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnonymMethod
{
    public class CarEventArgs : EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message)
        {
            msg = message;
        }
    }

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
                if (Exploded != null) Exploded(this, new CarEventArgs("Car is dead"));
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && AboutToBlow != null)

                    AboutToBlow(this, new CarEventArgs("Warning: Predel speed!"));

                if (CurrentSpeed >= MaxSpeed)

                    carIsDead = true;

                else Console.WriteLine("Current speed is {0}", CurrentSpeed);
            }
        }


        public delegate void CarEngineHandler(object sender, CarEventArgs e); //Определение делегата

        public event CarEngineHandler Exploded;     //Определение события
        public event CarEngineHandler AboutToBlow;  //Еще одно событие
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("car1", 100, 10);

            //---------------------------------------------------------------------------------------------------------
            car1.Exploded += delegate(object sender, CarEventArgs e) //Определение анонимного метода с параметрами
            {
                if (sender is Car)
                {
                    Car car = (Car)sender;

                    Console.WriteLine("****Message from Car object [{0}] (proc OnExploded): {1}", car.PetName, e.msg);
                }
            };

            car1.AboutToBlow += delegate (object sender, CarEventArgs e) //Определение анонимного метода с параметрами
            {
                if (sender is Car)
                {
                    Car car = (Car)sender;

                    Console.WriteLine("****Message from Car object [{0}] (proc OnAboutToBlow): {1}", car.PetName, e.msg);
                }
            };

            //---------------------------------------------------------------------------------------------------------
            for (int i = 0; i < 6; i++)

                car1.Accelerate(20);

            Console.ReadLine();
        }
    }
}

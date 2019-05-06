/* Пример работы с делегатами. 
 * 
 * Отличается от примера ConsoleDelegate2 тем, что регистрация обработчика происходит с помощью "группового преобразования методов".
 * 
 * Т.е. создание объекта-делегата происходит скрыто, в коде передается только имя обработчика OnCarEvent
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate3
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
                if (listOfHandlers != null) listOfHandlers("Car is dead");
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)

                    listOfHandlers("Warning: Predel speed!");

                if (CurrentSpeed >= MaxSpeed)

                    carIsDead = true;

                else Console.WriteLine("Current speed is {0}", CurrentSpeed);
            }
        }

        //делегат
        public delegate void CarEngineHandler(string message);

        private CarEngineHandler listOfHandlers;

        public void RegistryHandler(CarEngineHandler handler)
        {
            listOfHandlers += handler;
        }
        public void UnRegistryHandler(CarEngineHandler handler)
        {
            listOfHandlers -= handler;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("car1", 100, 10);

            car1.RegistryHandler(OnCarEvent); //То, чем отличаются проекты ConsoleDelegate3 От ConsoleDelegate2
                                              //Можно не создавать объект, а сразу передать метод делегату
                                              //Система сама создат объект-делегат и задаст метод для обратного вызова

            for (int i = 0; i < 6; i++)

                car1.Accelerate(20);

            car1.UnRegistryHandler(OnCarEvent); //Отмена регистрации метода у делегата

            //------------------------------------------------
            Console.WriteLine("\nAfter UnRegistered method");
            
            car1.CurrentSpeed = 10;
            
            car1.IsDead = false;

            for (int i = 0; i < 6; i++)

                car1.Accelerate(20);

            Console.WriteLine("Car is died: {0}", car1.IsDead);

            Console.ReadLine();
        }
        public static void OnCarEvent(string message)
        {
            Console.WriteLine("****Message from Car object:");

            Console.WriteLine(message);
        }
    }
}

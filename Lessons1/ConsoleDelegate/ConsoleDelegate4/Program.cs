/* Пример использования обобщенного делегата
 * 
 * Обощенный делегат: public delegate void CarEngineHandler<T>(T message);
 * 
 * Определяется с помощью ключевого слова delegate. 
 *                void - nип возвращаемого значения
 *                CarEngineHandler<T> - имя делегата, где <T> - тип, который будет определен позже
 *                (T message) - список параметров
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate4
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
        public delegate void CarEngineHandler<T>(T message); //Обобщенный делегат

        private CarEngineHandler<string> listOfHandlers; //

        public void RegistryHandler(CarEngineHandler<string> handler)
        {
            listOfHandlers += handler;
        }
        public void UnRegistryHandler(CarEngineHandler<string> handler)
        {
            listOfHandlers -= handler;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("car1", 100, 10);

            car1.RegistryHandler(OnCarEvent); 

            for (int i = 0; i < 6; i++)

                car1.Accelerate(20);

            car1.UnRegistryHandler(OnCarEvent); //Отмена регистрации метода у делегата
            
            Console.ReadLine();
        }
        public static void OnCarEvent(string message)
        {
            Console.WriteLine("****Message from Car object:");

            Console.WriteLine(message);        
        }
    }
}

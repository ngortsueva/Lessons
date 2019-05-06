using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate2
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

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

            car1.RegistryHandler(new Car.CarEngineHandler(OnCarEvent));

            for (int i = 0; i < 6; i++)

                car1.Accelerate(20);

            Console.ReadLine();
        }
        public static void OnCarEvent(string message)
        {
            Console.WriteLine("****Message from Car object:");
            
            Console.WriteLine(message);
        }
    }
}

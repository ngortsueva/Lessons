using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using System.Configuration; //Пространство имен для чтения конфигурационного файла приложения

namespace ConsoleAssembly
{ 
    class Program
    {
        static void Main(string[] args)
        {
            
            AppSettingsReader reader = new AppSettingsReader(); //Объект для чтения конфиг. файла приложения

            string name = (String)reader.GetValue("CarName", typeof(string)); //Получение параметра из конфиг. файла

            Car car1 = new Car();
            car1.Name = name;
            car1.Print();

            Console.ReadLine();
        }
    }
}

/* Пример демонстрирует как работать с классами Сериализации
 * 
 * Для этого новый класс помечается аттрибутом [Serializable].
 * 
 * После чего пишется процедур сохранения в файл (чтение из файла), в которой используется тот или иной форматтер.
 * 
 * Виды форматтеров:
 *      - BinaryFormatter
 *      - SoapFormatter
 *      - XmlSerializer
 *      
 * В каждом форматтере есть процедуры Serialize и Deserialize, которым передаются FileStream-объект и объект(который нужно сериализовать).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleSerialize
{
    [Serializable]
    public class Car
    {
        public string name;
        protected string color;
        protected int maxspeed;

        public Car()
        {
            name = "";
            color = "";
            maxspeed = 0;
        }

        public Car(string name, string color, int maxspeed)
        {
            this.name = name;
            this.color = color;
            this.maxspeed = maxspeed;
        }

        public string Color { get { return color; } set { color = value; } }

        public int MaxSpeed { get { return maxspeed; } set { maxspeed = value; } }

        public virtual void Print()
        {
            try
            {
                Console.WriteLine("Car: name = {0}, color = {1}, maxspeed = {2}", name, color, maxspeed.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class SuperCar : Car
    {
        public string type;
        public SuperCar() : base() { type = "supercar"; }

        public SuperCar(string name, string color, int maxspeed) : base(name, color, maxspeed) { type = "supercar";  }

        public override void Print()
        {
            Console.WriteLine("Car: name = {0}, color = {1}, maxspeed = {2}, type = {3}", name, color, maxspeed, type);
        }
    }

    class Program
    {
        //--------------------------------------------Binary Formatter---------------------------------------------------------
        public static void SaveToBinary(object objGraph, string filename)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            using(Stream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fs, objGraph);
            }
            Console.WriteLine("Object is serialize");
        }

        public static Object ReadFromBinary(string filename)
        {
            Object obj;

            BinaryFormatter binFormat = new BinaryFormatter();

            using(Stream fs = File.OpenRead(filename))
            {
                obj = binFormat.Deserialize(fs);
            }
            return obj;
        }

        //--------------------------------------------SOAP Formatter---------------------------------------------------------
        public static void SaveToSoap(object objGraph, string filename)
        {
            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fs, objGraph);
            }
            Console.WriteLine("Object is serialize");
        }

        public static Object ReadFromSoap(string filename)
        {
            Object obj;

            SoapFormatter binFormat = new SoapFormatter();

            using (Stream fs = File.OpenRead(filename))
            {
                obj = binFormat.Deserialize(fs);
            }
            return obj;
        }

        //--------------------------------------------XML Formatter---------------------------------------------------------
        public static void SaveToXML(object objGraph, string filename)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Car), new Type[] {typeof(Car), typeof(SuperCar)});

            using (Stream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fs, objGraph);
            }
            Console.WriteLine("Object is serialize");
        }

        public static Object ReadFromXML(string filename)
        {
            Object obj;

            XmlSerializer xmlFormat = new XmlSerializer(typeof(Car), new Type[] {typeof(Car), typeof(SuperCar)});

            using (Stream fs = File.OpenRead(filename))
            {
                obj = xmlFormat.Deserialize(fs);
            }
            return obj;
        }

        //-----------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("Objects:");
            Car car1 = new Car("car1", "black", 60);
            Car car2 = new Car("car2", "white", 120);
            SuperCar car3 = new SuperCar("car3", "green", 250);

            car1.Print();
            car2.Print();
            car3.Print();

            Console.ReadLine();

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Test Binary Formatter");

            Console.WriteLine("1. Write to file:");

            SaveToBinary(car1, "car1.dat");
            SaveToBinary(car2, "car2.dat");
            SaveToBinary(car3, "car3.dat");

            Console.WriteLine("");

            Console.WriteLine("2. Read from file:");

            Car carRestore1 = (Car)ReadFromBinary("car1.dat");
            Car carRestore2 = (Car)ReadFromBinary("car2.dat");
            Car carRestore3 = (Car)ReadFromBinary("car3.dat");

            carRestore1.Print();
            carRestore2.Print();
            carRestore3.Print();

            if (car1 is Car) Console.WriteLine("Object [{0}] is Car", car1.name);
            
            if (car1 is SuperCar) Console.WriteLine("Object [{0}] is SuperCar", car1.name);
            else Console.WriteLine("Object [{0}] is not SuperCar", car1.name);

            if (car3 is SuperCar) Console.WriteLine("Object [{0}] is SuperCar", car3.name);

            Console.ReadLine();

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Test Soap Formatter");

            Console.WriteLine("1. Save to file by SOAP Formatter");
            SaveToSoap(car1, "car1.soap");
            SaveToSoap(car2, "car2.soap");
            SaveToSoap(car3, "car3.soap");

            Console.WriteLine("");

            Console.WriteLine("2. Read from file by SOAP Formatter");
            Car carRestore4 = (Car)ReadFromSoap("car1.soap");
            Car carRestore5 = (Car)ReadFromSoap("car2.soap");
            Car carRestore6 = (Car)ReadFromSoap("car3.soap");

            carRestore4.Print();
            carRestore5.Print();
            carRestore6.Print();

            Console.ReadLine();

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Test Xml Formatter");

            Console.WriteLine("1. Save to file by XML Formatter");

            SaveToXML(car1, "car1.xml");
            SaveToXML(car2, "car2.xml");
            SaveToXML(car3, "car3.xml");

            Console.WriteLine("");

            Console.WriteLine("2. Read from file by XML Formatter");

            Car carRestore7 = (Car)ReadFromXML("car1.xml");
            Car carRestore8 = (Car)ReadFromXML("car2.xml");
            Car carRestore9 = (Car)ReadFromXML("car3.xml");

            carRestore7.Print();
            carRestore8.Print();
            carRestore9.Print();

            if (carRestore9 is SuperCar) Console.WriteLine("carRestore9 is SuperCar");
            Console.ReadLine();
        }
    }
}

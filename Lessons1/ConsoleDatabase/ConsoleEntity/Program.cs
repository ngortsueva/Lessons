/* Пример показывает как работать с ADO.NET Entity Framework
 * 
 * Файл InventoryEDM.edmx - то, что генерирует мастер при добавлении в проект элемента Data->"ADO.NET Entity Data Model"
 * 
 * Генерируются ряд файлов-шаблонов с расширением *.tt.
 * 
 * Генерируюся cs-файлы с определением классов Entity: Car.cs, InventoryEDM.Context.cs, InventoryEDM.cs
 * 
 * Приэтом изначально на диаграмме InventoryEDM.edmx класс назывался "Inventory" (так же как таблица). 
 * Затем он был переименован в Car, а свойство PetName - в CarName.
 * 
 * В самой программе используется несколько объектов: AutoLotEntities и Car.
 * 
 * AutoLotEntities context - осуществляет доступ ко всей базе.
 * context.Cars - коллекция для доступа ко всем объектам Car, т.е. представляет все строки таблицы Inventory.
 * 
 * Также если бы в мастере были бы выбраны и другие таблицы, то были бы сгенерированы и другие коллекции, которые соответствовали
 * таблицам базы данных.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleEntity
{
    
    class Program
    {
        //Процедура добавления записи в коллекцию Cars и сохранение изменений в таблице Inventory.
        private static void AddRecord()
        {
            using(AutoLotEntities context = new AutoLotEntities())
            {
                try
                {
                    context.Cars.Add(new Car() { CarID = 15, Make = "GAZ", Color = "Black", CarName = "Volga" });

                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Процедура удаления элемента Car
        private static void RemoveRecord()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                try
                {
                    Car c = context.Cars.Find(15);
                    
                    context.Cars.Remove(c);

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Процедура использует LINQ to Entities. Удаляется запись из таблицы Inventory
        private static void RemoveRecordByLINQ()
        {
            using(AutoLotEntities context = new AutoLotEntities())
            {
                var c = (from car in context.Cars where car.CarID == 15 select car).FirstOrDefault();

                if (c != null)
                {
                    context.Cars.Remove((Car)c);

                    context.SaveChanges();
                }
            }
        }

        //Процедура обновления записи в таблице Inventory
        private static void UpdateRecord()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                try
                {
                    Car c = context.Cars.Find(14);

                    c.CarName = "Niva Good2";

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void SelectByEntitySQL()
        {
            //Данный код пока не работает
            /*
            using (AutoLotEntities context = new AutoLotEntities())
            {
                string query = "SELECT VALUE car FROM AutoLotEntities.Cars + AS car WHERE car.Color == 'Black'";               
            }
            */
        }

        private static void SelectByEntitySQL_2()
        {
            //Данный код пока не работает
            /*
            using(EntityConnection cn = new EntityConnection(""))
            {
                
            }
            */
        }

        //Процедура вывода на экран таблицы Inventory 
        private static void PrintInventory()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                try
                {
                    foreach (Car c in context.Cars) Console.WriteLine(c);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("\n****Add Car to Inventory****\n");
            AddRecord();
            PrintInventory();

            Console.ReadLine();

            Console.WriteLine("\n****Remove Car from Inventory****\n");
            //RemoveRecordByLINQ();
            PrintInventory();

            Console.ReadLine();

            Console.WriteLine("\n****Update Car from Inventory****\n");
            UpdateRecord();
            PrintInventory();
            */

            //SelectByEntitySQL();
            //SelectByEntitySQL_2();

            FormCars form = new FormCars();
            
            form.ShowDialog();

            Console.ReadLine();
        }
    }
}

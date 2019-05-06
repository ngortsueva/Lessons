/* Пример описывает применение классов из пространства имен System.Reflection - реализации позднего связывания в .Net.
 * 
 * Процедура CheckTypeCar - показывает как можно получать динамическую информацию о типе (классе)
 * 
 * Процедура GetAssemblyInfo - получение информации о сборке
 * 
 * Процедура CreateCarType - пример позднего связывания и как при этом вызываются свойства и методы объекта при отсутствии строгой информации о типе
 * 
 * Здесь также показано как создавать пользовательские аттрибуты и указать их область применения
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ConsoleReflection
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Class)] //Ограничения применения аттрибута
        public sealed class CarDescAttribute : System.Attribute //Определение пользовательского аттрибута
        {
            public string Description { get; set; }

            public CarDescAttribute() { }
            public CarDescAttribute(string attrDesc)
            {
                Description = attrDesc;
            }

        }

        [CarDesc("MyCar")]  //Применение пользовательского аттрибута к классу
        public class Car : ICloneable
        {
            public string name;

            //[Car("MyCar")] - Если убрать комментарии - будет ошибка, т.к. область действия аттрибута CarAttribute применимо только к классам
            public Car()
            {
                name = "";
            }

            public string Name { get { return name; } set { name = value; } }
                       
            public void Print()
            {
                Console.WriteLine(name);
            }

            public object Clone()
            {
                Car temp = new Car();

                temp.Name = this.Name;
                
                return temp;
            }
        }

        [CarDesc("MySuperCar")]
        class SuperCar { }

        public static void CheckTypeCar()
        {
            Car car = new Car();

            Type t = car.GetType();

            GetTypeInfo(t);
            ListInterface(t);
            ListFields(t);
            ListProperties(t);
            ListMethods(t);
        }

        //Получение информации о сборке
        public static void GetAssemblyInfo(Assembly asm)
        {
            Console.WriteLine("Codebase: {0}", asm.CodeBase);
            if (asm.EntryPoint != null) Console.WriteLine("Entry point: {0}", asm.EntryPoint.Name);
            Console.WriteLine("Full name: {0}", asm.FullName);            
            Console.WriteLine("Location: {0}", asm.Location);
            Console.WriteLine("Name: {0}", asm.GetName().Name);
            Console.WriteLine("Version: {0}", asm.GetName().Version);
            Console.WriteLine("Culture info: {0}", asm.GetName().CultureInfo.DisplayName);
           
            Console.WriteLine("Types: ");
            foreach(Type t in asm.GetTypes())
            {
                Console.WriteLine("Name: {0}", t.Name);
            }
        }        

        //Получение информации о типе
        public static void GetTypeInfo(Type t)
        {
            Console.WriteLine("*************Info*************");
            Console.WriteLine("Assembly: {0}", t.Assembly);
            Console.WriteLine("Namespace: {0}", t.Namespace);
            Console.WriteLine("Base type: {0}", t.BaseType);
            Console.WriteLine("Full name: {0}", t.FullName);
            Console.WriteLine("GUID: {0}", t.GUID);
            Console.WriteLine("Name: {0}", t.Name);

            Console.WriteLine("Assembly info:");
            GetAssemblyInfo(t.Assembly);
        }

        //Получение списка интерфейсов у заданного типа
        public static void ListInterface(Type t)
        {
            Console.WriteLine("*************Interfaces*************");
            
            foreach(Type i in t.GetInterfaces())
            {
                Console.WriteLine(i.Name);
            }
        }

        //Получение списка полей у заданного типа
        public static void ListFields(Type t)
        {
            Console.WriteLine("*************Fields*************");

            foreach (FieldInfo f in t.GetFields())
            {
                Console.WriteLine("{0} ", f.Name);
                //ListParams(m);
            }
        }

        //Получение списка свойств у заданного типа
        public static void ListProperties(Type t)
        {
            Console.WriteLine("*************Properties*************");

            foreach (PropertyInfo p in t.GetProperties())
            {
                Console.WriteLine("{0} ", p.Name);
                //ListParams(m);
            }
        }

        //Получение списка методов у заданного типа
        public static void ListMethods(Type t)
        {
            Console.WriteLine("*************Method*************");

            foreach (MethodInfo m in t.GetMethods())
            {
                string retVal = m.ReturnType.FullName;

                string paramInfo = "(";

                foreach (ParameterInfo pi in m.GetParameters())
                {
                    paramInfo += string.Format("{0} {1}", pi.ParameterType, pi.Name);
                }

                paramInfo += ")";

                Console.WriteLine("{0} {1}{2}", retVal, m.Name, paramInfo);
            }
        }


        //Процедура динамической загрузки сборки с помощью класса Assembly
        public static void LoadAssembly()
        {
            Assembly asm = Assembly.LoadFrom("D:\\Labs\\Development\\Projects\\Net\\Console\\ConsoleAssembly\\CarLibrary\\bin\\Debug\\CarLibrary.dll");

            GetAssemblyInfo(asm);

            //CreateCarType(asm);
            CreateCarType2(asm);
        }

        //Процедура создания объекта с помощью позднего связывания
        //Используется класс Activator
        public static void CreateCarType(Assembly asm)
        {
            Console.WriteLine("\n****Create instance by Activator");
            try
            {
                Type carType = asm.GetType("CarLibrary.Car"); //Получение типа объекта

                object car = Activator.CreateInstance(carType); //Создание объекта

                Console.WriteLine("Create object: {0}", car);

                //Использование свойства объекта
                PropertyInfo prop = carType.GetProperty("Name"); //Получение информации о свойстве объекта

                prop.SetValue(car, "Ford");

                //Вызов метода полученного объекта
                MethodInfo method = carType.GetMethod("Print"); //Получение информации о методе Print

                method.Invoke(car, null); //Вызов метода


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Процедура создания объекта с помощью позднего связывания
        //Используется класс Activator
        //Используется ключевое слово dynamic, которое упращает обращение к свойствам, полям и методам объекта созданного с помощью позднего связывания
        public static void CreateCarType2(Assembly asm)
        {
            Console.WriteLine("\n****Create instance by Activator");
            try
            {
                Type carType = asm.GetType("CarLibrary.Car"); //Получение типа объекта

                dynamic car = Activator.CreateInstance(carType); //Создание объекта

                car.Name = "Audi";

                car.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReflectOnAttribute()
        {
            Type t = typeof(Car);

            object[] customAtts = t.GetCustomAttributes(false);

            foreach(CarDescAttribute at in customAtts)
            {
                Console.WriteLine("attribute for car: {0}", at.Description);
            }
        }

        public static void ReflectOnAttributeLateBindings()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            try
            {
                Type carAttrType = typeof(CarDescAttribute);

                PropertyInfo prop = carAttrType.GetProperty("Description");

                Type[] types = asm.GetTypes();

                foreach(Type t in types)
                {
                    object[] obj = t.GetCustomAttributes(carAttrType, false);

                    foreach(object o in obj)
                    {
                        Console.WriteLine("Type: {0}, CarAttribute: {1}", t.Name, prop.GetValue(o, null));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            //CheckTypeCar();

            //LoadAssembly();

            //ReflectOnAttribute();

            ReflectOnAttributeLateBindings();

            //Использование ключевого слова dynamic
            dynamic car = new Car();
            car.Name = "VAZ";
            car.Print();

            LoadAssembly();

            Console.ReadLine();
        }
    }
}

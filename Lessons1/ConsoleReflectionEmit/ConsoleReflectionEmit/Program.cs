/* Пример описывает работу с пространством имен System.Reflection.Emit, которое используется для динамического построения сборки
 * 
 * Здесь создается сборка MyCar.dll, в которое определено пространство имен MyCar и класс Car.
 * Класс Car состоит из одного поля name, конструктора по умолчанию и конструктора с одним строковым параметром. 
 * Также класс содержит метод Print для вывода на консоль поля name;
 * Сборка сохраняется в файл MyCar.dll
 * 
 * После создания сборки она загружается в текущий процесс с помощью класса Assembly из пространства имен System.Reflection.
 * С помощью статического класса Activator создается объект типа Car.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace ConsoleReflectionEmit
{
    class Program
    {
        public static void CreateAssembly(AppDomain curDomain)
        {
            AssemblyName asmName = new AssemblyName();
            asmName.Name = "MyCar";
            asmName.Version = new Version("1.0.0.0");

            //Создание сборки
            AssemblyBuilder asmBuilder = curDomain.DefineDynamicAssembly(asmName, AssemblyBuilderAccess.Save);

            //Создание модуля в сборке
            ModuleBuilder modBuilder = asmBuilder.DefineDynamicModule("MyCar", "MyCar.dll");

            //Создание типа (класс) в модуле
            TypeBuilder carTypeBuilder = modBuilder.DefineType("MyCar.Car", TypeAttributes.Public);

            //Определение полей (переменных) в созданном классе
            FieldBuilder fieldName = carTypeBuilder.DefineField("name", Type.GetType("System.String"), FieldAttributes.Private);

            //Создание конструктора
            Type[] constructorArgs = new Type[1]; //Определение параметров конструктора

            constructorArgs[0] = typeof(string);

            ConstructorBuilder conBuilder = carTypeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, constructorArgs); //Конструктор

            ILGenerator gen = conBuilder.GetILGenerator(); //Получение ILGenerator для будущего конструктора
            
            Type objClass = typeof(object);
            ConstructorInfo superConstructor = objClass.GetConstructor(new Type[0]); //Определение суперконстуктора (конструктор базового класса)

            gen.Emit(OpCodes.Ldarg_0);                    //Генерация команд CIL
            gen.Emit(OpCodes.Call, superConstructor);
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.Emit(OpCodes.Stfld, fieldName);
            gen.Emit(OpCodes.Ret);

            //Определение конструктора по умолчанию
            carTypeBuilder.DefineDefaultConstructor(MethodAttributes.Public);

            //Определение метода Print
            MethodBuilder methodPrint = carTypeBuilder.DefineMethod("Print", MethodAttributes.Public);
            ILGenerator method_gen = methodPrint.GetILGenerator();

            method_gen.EmitWriteLine(fieldName);
            method_gen.Emit(OpCodes.Ret);

            carTypeBuilder.CreateType();

            asmBuilder.Save("MyCar.dll");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("****Generate Assembly and save to file****");

            AppDomain domain = Thread.GetDomain();

            //Динамическое создание сборки
            CreateAssembly(domain);

            Console.WriteLine("****Finished");

            Console.WriteLine("\nLoad assembly");

            //Динамическая загрузка сборки
            Assembly asm = Assembly.Load("MyCar");

            Type car = asm.GetType("MyCar.Car");  //Получение типа Car

            string name = "Ferrary";

            object[] carArgs = new object[1];     //Строковый параметр, который будет передан конструктору класса Car
            carArgs[0] = name;

            //Создание объекта типа Car
            dynamic obj = Activator.CreateInstance(car, carArgs);

            obj.Print();

            Console.ReadLine();
        }
    }
}

/* Пример показывает как работать с перегрузкой операции
 *
 * В классе Point3D также определен способ неявного преобразования из типа Point с помощью ключевого слова implicit
 *
 * В классе Person показано как переопределять методы Equals, ToString, GetHashCode, которые наследованы от System.Object
 *
 * В классе PersonCollection показано как определять метод-индексатор с помощью конструкции this[int index] 
 *
 * Класс PointExt - определеяет дружественные методы для классов Point и Point3D
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleOperation
{
    class Point : IComparable<Point>
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator + (Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator + (Point p1, int delta)
        {
            return new Point(p1.x + delta, p1.y + delta);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        public static Point operator - (Point p1, int delta)
        {
            return new Point(p1.x - delta, p1.y - delta);
        }

        public static Point operator ++ (Point p1)
        {
            return new Point(p1.x + 1, p1.y + 1);
        }

        public static Point operator -- (Point p1)
        {
            return new Point(p1.x - 1, p1.y - 1);
        }

        public static bool operator == (Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator != (Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

        public static bool operator > (Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator < (Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >= (Point p1, Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }

        public static bool operator <= (Point p1, Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }

        public static Point operator * (Point p1, int delta)
        {
            return new Point(p1.x * delta, p1.y * delta);
        }

        public static Point operator / (Point p1, int delta)
        {
            return new Point(p1.x / delta, p1.y / delta);
        }

        public override bool Equals(Object obj)
        {
            Point p = (Point)obj;

            if (x == p.x && y == p.y) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() + y.GetHashCode();
        }

        public override string ToString()
        {
            return x.ToString() + " " + y.ToString();
        }

        public int CompareTo(Point p)
        {
            if (x > p.x && y > p.y) return 1;

            if (x < p.x && y < p.y) return -1;

            return 0;
        }

        public void Print()
        {
            Console.WriteLine("Point: x={0}, y={1}", x, y);
        }
    }

    class Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Point3D(Point p)
        {
            Point3D p3d = new Point3D(p.x, p.y, 0);

            return p3d;
        }

        public void Print()
        {
            Console.WriteLine("Point3D x = {0}, y = {1}, z = {2}", x, y, z);
        }
    }
    class Person : ICloneable, IComparable
    {
        public const int rost = 10; //Определение константы (значение должно присваиваться тут же)
        public readonly int ves;    //Определение переменной только для чтения. Присваивание выполняется единожды и только в конструкторе.
        public static readonly int ves2 = 15; //Определение статической переменной только для чтения.

        private string name;
        private int old;
        public Person()
        {
            name = "";
            old = 0;
            Family = "";

            ves = 10;
            
        }

        public Person(string name) : this()
        {
            this.name = name;
        }

        public Person(string name = "", int old = 0) : this(name)
        {
            this.old = old;
        }

        public Person(string name = "name", string family = "empty", int old = 0)
            : this(name, old)            
        {
            this.Family = family;
        }

        //Определение свойств класса
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int Old
        {
            get { return old; }
            set { old = value; }
        }

        public string Family { get; set; } //Автоматическое свойство

        //Перегрузка метода ToString класс Object
        public override string ToString()
        {
            return name + "," + old;
        }

        //Перегрузка метода GetHashCode класс Object
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        //Перегрузка метода Equals класс Object
        public override bool Equals(object obj)
        {
            Person p = (Person)obj;

            if (Name == p.Name && Old == p.Old) return true;
            else return false;
        }

        //Реализация метода Clone интерфейса ICloneable
        public object Clone()
        {
            return new Person(this.name, this.Family, this.old);
        }

        //Реализация метода CompareTo интерфейса IComparable
        public int CompareTo(object o)
        {
            Person p = (Person)o;
            if (p != null)
            {
                if (old > p.old) return 1;

                if (old < p.old) return -1;
                else
                    return 0;
            }
            else throw new ArgumentException("Paramter is not Person.");
        }

        public void GetPerson(out string strName){ strName = name; }
        public void GetPersonRef(ref string strName) { if (strName != null) Console.WriteLine(strName); strName = name; }

        public void SetObjectParam(string name = "Empty", int old = 0) { Name = name; Old = old; }

        public void Print() { Console.WriteLine("{0} - {1}, Family = {2}", name, old, Family); }

        public void PrintNames(params string[] data) { for (int i = 0; i < data.Length; i++)Console.WriteLine(data[i]); }
    }

    class PersonCollection : IEnumerable
    {
        protected ArrayList group;

        public PersonCollection() 
        {
            group = new ArrayList();
        }

        //Перегрузка оператора-индексатора
        public Person this[int index]
        {
            get { return (Person)group[index]; }
            set { group.Insert(index, value); }
        }

        //Перегрузка оператора-индексатора
        public Person this[string name]
        {
            get 
            {                 
                foreach(Person p in group)
                {
                    if (p.Name == name) return p;
                }
                return null;
            }
        }

        public int Count
        {
            get { return group.Count; }
        }        
        public void Add(Person p)
        {
            group.Add(p);
        }
        public void Delete(Person p)
        {
            group.Remove(p);
        }

        //Реализация метода GetEnumerator интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return group.GetEnumerator();
        }

        public void Sort()
        {
            group.Sort();
        }
    }

    //Класс реализиет расширяющие методы для классов Point и Point3D
    static class PointExt  //Обязательно должен быть статическим
    {
        //Метод должен быть статическим
        public static void PrintDef(this Point p)
        {
            Console.WriteLine("New fried method for Point: x = {0}, y = {1}", p.x, p.y);
        }

        public static void PrintDef3D(this Point3D p)
        {
            Console.WriteLine("New fried method for Point3D: x = {0}, y = {1}, z = {2}", p.x, p.y, p.z);
        }
    }
    class Program
    {
        public static void TestPersonClass()
        {
            PersonCollection people = new PersonCollection();

            people[0] = new Person( "smit", 25);
            people[1] = new Person( "jack", 24);
            people[2] = new Person( "travel", 22);
            people.Add(new Person("sergey", 21));
            people.Add(new Person("alex", 20));

            //-------------------------------------------------------------------------------------
            //Определение индексатора
            Console.WriteLine("1:");
            foreach(Person p in people)
            {
                Console.WriteLine("{0} - {1}", p.Name, p.Old);
            }

            people.Sort(); //Сортировку можно провести благодаря реализации CompareTo интерфейса IComparable

            Console.WriteLine("2:");

            for (int i = 0; i < people.Count; i++ )
            {
                Console.WriteLine("{0} - {1}", people[i].Name, people[i].Old);
            }

            Console.WriteLine("Find operation:");

            Console.WriteLine("Find person: {0} - {1}", people["travel"].Name, people["travel"].Old);

            //-------------------------------------------------------------------------------------
            Console.WriteLine("Compare string");

            string str1 = "str";
            string str2 = "str";
            Console.WriteLine("String 1: {0}, HashCode: {1}", str1, str1.GetHashCode());
            Console.WriteLine("String 2: {0}, HashCode: {1}", str2, str2.GetHashCode());


            if (str1 == str2) Console.WriteLine("String is Equals");
            else
                Console.WriteLine("String is not equals");

            if (str1.Equals(str2)) Console.WriteLine("String is Equals 2");
            else
                Console.WriteLine("String is not equals 2");


            //-------------------------------------------------------------------------------------
            //Перегрузка методов ToString(), GetHashCode, Equals в классе Person

            Console.WriteLine("Compare person");

            Person p1 = new Person("smit", 20);
            Person p2 = new Person("smit", 20);

            Console.WriteLine("Person 1: {0}, {1}", p1, p1.ToString().GetHashCode());
            Console.WriteLine("Person 2: {0}, {1}", p2, p2.ToString().GetHashCode());

            if (p1 == p2) Console.WriteLine("Object is equals"); //Здесь происходит сравнение ссылок, т.к. операторы == и != не перегружены в класс Person
            else Console.WriteLine("Object is not equals");

            if (p1.Equals(p2)) Console.WriteLine("Object is equals 2 (method Equals)"); //Сравнение с помощью перегруженного метода Equals()
            else Console.WriteLine("Object is not equals 2 (method Equals)");

            if (p1.ToString() == p2.ToString()) Console.WriteLine("Object is equals 3 (ToString())"); //Сравнение с помощью перегруженного метода ToString()
            else Console.WriteLine("Object is not equals 3 (ToString())");

            if (p1.ToString().GetHashCode() == p2.ToString().GetHashCode()) Console.WriteLine("Object is equals 4 (HashCode)"); //Сравнение с помощью перегруженного метода GetHashCode()
            else Console.WriteLine("Object is not equals 4 (HashCode)");


            //-------------------------------------------------------------------------------------
            //Использование ключевых слов out и ref
            //out - данные могут только возвращаться из метода
            //ref - данные могут передаваться в обоих направлениях
            string str3 = "str3";

            p1.GetPerson(out str3);

            Console.WriteLine("Use 'out' param in method GetPerson: {0}", str3);

            string str4 = "str4";

            p1.GetPersonRef(ref str4);

            Console.WriteLine("Use 'ref' param in method GetPersonRef: {0}", str4);

            p1.PrintNames("str1", "str2", "str3");

            p1.PrintNames(new string[] {"str1", "str2", "str3"});
            
            //-------------------------------------------------------------------------------------
            //Использование синтаксиса параметров метода со значениями по умолчанию.
            //Выборочное задание параметров.
            Console.WriteLine("");

            p1.SetObjectParam(name: "Smit");
            p1.Print();

            p1.SetObjectParam(name: "Jack", old: 20);
            p1.Print();

            Person p3 = new Person();
            p3.SetObjectParam(old: 21);
            p3.Print();

            //---------------------------------------------------------------------------------------
            //Использование синтаксиса параметров констуктора со значениями по умолчанию.
            Person p4 = new Person();
            Person p5 = new Person(name: "Kate");
            p5.Print();

            Person p6 = new Person(name: "", old: 25);
            p6.Print();

            Person p7 = new Person(name: "Kate2", old: 27);
            p7.Family = "Flower";
            p7.Print();

            //Создание объекта с помощью синтаксиса инициализации
            Person p8 = new Person { Name = "Kate3", Family = "Flower3", Old = 28 };
            p8.Print();

            Person p9 = new Person() { Name = "Kate4", Family = "Flower4", Old = 28 };
            p9.Print();

            Person p10 = new Person(name: "Kate5") { Family = "Flower5", Old = 29 };
            p10.Print();

            Person p11 = new Person(name: "Kate6", old: 30) { Family = "Flower6" };
            p11.Print();
            
            //Класс Person реализует интерфейс ICloneable
            Console.WriteLine("Use interface ICloneable");
            Person p12 = (Person)p11.Clone();
            p12.Name = "Kate7";
            p12.Family = "Flower7";

            Console.Write("First object "); p11.Print();
            Console.Write("Second object: ");  p12.Print();

            Person p13 = new Person("tim", "gigi", 20);
            Person p14 = p13;

            Console.Write("P13 object "); p13.Print();
            Console.Write("P14 object: "); p14.Print();

            p13.Name = "TIM 1";
            p13.Old = 25;

            Console.Write("P13 object "); p13.Print();
            Console.Write("P14 object: "); p14.Print();

            Console.ReadLine();
        }

        public static void TestPointClass()
        {
            Console.WriteLine("Test Point class.");

            Point p1 = new Point(10,10);  p1.Print();

            Point p2 = new Point(10, 10); p2.Print();

            p1 += 4; p1.Print();
            p1++;    p1.Print();

            Point p3 = p1 + p2;
            p3.Print();

            Point p4 = new Point(10, 10);
            Point p5 = new Point(10, 10);

            if (p4 == p5) Console.WriteLine("Point is equals: p4: {0}; p5: {1}", p4.ToString(), p5.ToString());

            if (p3 != p4) Console.WriteLine("Point is not equals p3: {0}; p4: {1}", p3.ToString(), p4.ToString());

            Point p6 = new Point(2, 2); 
            p6.Print();

            p6 *= 2;
            p6.Print();

            p6 = p6 * 2;
            p6.Print();

            Point p7 = new Point(50, 50);
            Point p8 = p7;

            p7.Print();
            p8.Print();
            p7 += 5;
            p8++;

            p7.Print();
            p8.Print();

            Console.ReadLine();
        }

        public static void TestPoint3DClass()
        {
            Point p1 = new Point(10, 10);
            Point3D p3d = (Point3D)p1;

            p1.Print();
            p3d.Print();

            p3d.x = 15;
            p3d.y = 20;
            p3d.z = 8;

            p1.Print();
            p3d.Print();

            Point p2 = new Point(100, 100);
            Point3D p3d_2 = p2;

            p2.Print();
            p3d_2.Print();

            //Использование расширяющих методов 
            p1.PrintDef();
            p3d.PrintDef3D();
        }

        

   
        static void Main(string[] args)
        {
            //TestPersonClass();

            //TestPointClass();

            TestPoint3DClass();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ConsoleThread
{
    public class Printer
    {
        private object threadLock = new object(); // Используется как маркер блокировки
        public void PrintNumbers()
        {
            lock (threadLock)
            {
                Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

                Console.WriteLine("Your numbers:");

                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();

                    Thread.Sleep(1000 * r.Next(5));

                    Console.Write("{0}, ", i);
                }
                Console.WriteLine("");
            }
        }

        //Используется в качестве примера в процедуре CreateSecondaryThread2
        public void PrintNumbers2(object flag)
        {
            Console.WriteLine("-> {0} is executing PrintNumbers(object flag)", Thread.CurrentThread.Name);

            Console.WriteLine("Your numbers:");

            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();

                Console.Write("{0}, ", i);

                Thread.Sleep(1000 * r.Next(5));
            }
            Console.WriteLine("");
        }

        //Второй вариант блокировки потока - вместо ключевого слова lock используется класс Monitor
        public void PrintNumbers3()
        {
            Monitor.Enter(threadLock);
            try
            {
                Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

                Console.WriteLine("Your numbers:");

                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();

                    Thread.Sleep(1000 * r.Next(5));

                    Console.Write("{0}, ", i);
                }
                Console.WriteLine("");
            }
            finally
            {
                Monitor.Exit(threadLock);
            }
        }
    }
    class Program
    {
        public static void GetThreadStats(Thread t)
        {
            Console.WriteLine("Friendly name: {0}", Thread.GetDomain().FriendlyName);
            Console.WriteLine("ContextID: {0}", Thread.CurrentContext.ContextID);
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("Is alive: {0}", t.IsAlive);
            Console.WriteLine("Is background: {0}", t.IsBackground);
            Console.WriteLine("Is thread pool: {0}", t.IsThreadPoolThread);
            Console.WriteLine("Priority: {0}", t.Priority);
            Console.WriteLine("State: {0}", t.ThreadState);
            
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //Процедура создания второго потока с использованием делегата ThreadStart
        public static void CreateSecondaryThread()
        {
            Thread.CurrentThread.Name = "Primary";

            Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);

            Printer p = new Printer();

            //Создание второго потока (параметры - делегат с указанием на процедуру, которую надо выполнять)
            Thread thread = new Thread(new ThreadStart(p.PrintNumbers));
            thread.Name = "Secondary";
            thread.IsBackground = true; //Фоновый поток (если главный поток закрывается, то и все фоновые потоки прекращают работу)
            thread.Start();

            Console.WriteLine("Main() is work");

            Console.ReadLine();
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //Отличие этой процедуры от предыдущей в том, что используется делегат ParameterizedThreadStart
        public static void CreateSecondaryThread2()
        {
            Thread.CurrentThread.Name = "Primary";

            Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);

            Printer p = new Printer();

            //Создание второго потока (параметры - делегат с указанием на процедуру, которую надо выполнять)
            Thread thread = new Thread(new ParameterizedThreadStart(p.PrintNumbers2));
            thread.Name = "Secondary";
            thread.IsBackground = true; //Фоновый поток (если главный поток закрывается, то и все фоновые потоки прекращают работу)
            thread.Start(true);         //Передаются параметры в поток (именно для этого и используется ParameterizedThreadStart)

            Console.WriteLine("Main() is work");

            Console.ReadLine();
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //Процедура создания 10 потоков, каждый из которых выводи числа от 0 до 9 с использованием одного и того же объекта p (класс Printer)
        //Для синхронизации доступа к объекту Print можно использовать ключевое слово lock или класс Monitor
        public static void CreateThreadInCircle()
        {
            Console.WriteLine("****Syncronize threads****");

            Printer p = new Printer();

            Thread[] threads = new Thread[10];

            for(int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers3));

                threads[i].Name = string.Format("Worker thread #{0}", i);
            }

            foreach (Thread t in threads) t.Start();

            Console.ReadLine();
        }

        //--------------------------------------------------------------------------------------------------
        //Процедура передается делегату TimerCallback, который используется при создании объекта Timer
        public static void PrintTime(object state)
        {
            Console.WriteLine("Time: {0}", DateTime.Now);
        }

        //Процедура создания объекта Timer
        public static void CreateTimer()
        {
            Console.WriteLine("****Working with Timer****");

            TimerCallback timerCB = new TimerCallback(PrintTime);

            Timer t = new Timer(timerCB, null, 0, 1000);

            Console.ReadLine();
        }

        //--------------------------------------------------------------------------------------------------
        public static void CreateThreadsFromPool()
        {
            Console.WriteLine("****Create threads from Pool****");

            Printer p = new Printer();

            WaitCallback workItem = new WaitCallback(PrintTheNumberForPools);

            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }

            Console.ReadLine();
        }

        public static void PrintTheNumberForPools(object state)
        {
            Printer p = (Printer)state;

            p.PrintNumbers();
        }

        //--------------------------------------------------------------------------------------------------------------
        //Обработка списка файлов
        public static void ProcessFiles()
        {
            string[] files = Directory.GetFiles("D:\\Temp\\3", "*.jpg");

            string resDir = "D:\\Temp\\4";

            foreach(string file in files)
            {
                string filename = Path.GetFileName(file);

                using(Bitmap bitmap = new Bitmap(file))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    bitmap.Save(Path.Combine(resDir, filename));

                    Console.WriteLine("Prosessing {0} on thread {1}", filename, Thread.CurrentThread.ManagedThreadId);
                }
            }
        }

        //Обработка списка файлов в потоках с помощью класса Parallel
        public static void ProcessFilesInThreads()
        {
            string[] files = Directory.GetFiles("D:\\Temp\\3", "*.jpg");

            string resDir = "D:\\Temp\\4";

            //Запуск нескольких потоков
            Parallel.ForEach(files, file =>
                {
                    string filename = Path.GetFileName(file);

                    using (Bitmap bitmap = new Bitmap(file))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        bitmap.Save(Path.Combine(resDir, filename));
                    }

                    Console.WriteLine("Prosessing {0} on thread {1}", filename, Thread.CurrentThread.ManagedThreadId);
                }
            );
        }

        //Запуск процедуры с помощью Task - в результате пользовательский интерфейс больше не блокируется (асинхронно)
        public static void ProcessImageByTask()
        {
            Task.Factory.StartNew(() =>
                {
                    ProcessFilesInThreads();
                }
            );
        }

        //--------------------------------------------------------------------------------------------------------------
        //Обработка списка файлов с помощью метода Parallel.Invoke()
        public static void ProcessImageByInvoke()
        {
            string[] files = Directory.GetFiles("D:\\Temp\\3", "*.jpg");

            string resDir = "D:\\Temp\\4";

            Parallel.Invoke(
                () => 
                {
                    Rotate(files, resDir);
                }
            );
        }

        public static void Rotate(string[] files, string resDir)
        {
            foreach(string file in files)
            {
                string filename = Path.GetFileName(file);

                using (Bitmap bitmap = new Bitmap(file))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    bitmap.Save(Path.Combine(resDir, filename));
                    
                    Console.WriteLine("Prosessing {0} on thread {1}", filename, Thread.CurrentThread.ManagedThreadId);
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------
        //PLINQ
        public static void ProcessInData()
        {
            int[] source = Enumerable.Range(1, 2000000).ToArray();

            int[] result = (from num in source.AsParallel() where num % 1233 == 0 orderby num descending select num).ToArray();

            Console.WriteLine("Found {0} numbers", result.Count());
        }

        //--------------------------------------------------------------------------------------------------------------
        //async, await
        public static async void StartWork()
        {
            string str = await DoWork();

            Console.WriteLine(str);
        }

        public static Task<string> DoWork()
        {
            return Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    return string.Format("Thread #{0}", Thread.CurrentThread.ManagedThreadId);
                }   
            );
        }


        //--------------------------------------------------------------------------------------------------------------
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);
        private static CancellationToken token = new CancellationToken();
        static void Main(string[] args)
        {
            //GetThreadStats(Thread.CurrentThread);

            //CreateSecondaryThread();

            //CreateSecondaryThread2();

            //CreateThreadInCircle();

            //CreateTimer();

            //CreateThreadsFromPool();

            //ProcessFiles();
            //ProcessFilesInThreads();  //Использование класса Parallel


            //ProcessImageByTask();    //Использование класса Task
            //ProcessImageByInvoke();  //Использование метода Parallel.Invoke()

            //ProcessInData();         //Использование PLINQ
            Console.WriteLine("Thread is #{0}", Thread.CurrentThread.ManagedThreadId);
            StartWork();

            Console.WriteLine("Something doing...");

            Console.ReadLine();
        }
    }
}

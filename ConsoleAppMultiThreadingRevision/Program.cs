//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleAppMultiThreadingRevision
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Thread thread = Thread.CurrentThread;
//            thread.Name = "main";
//            Console.WriteLine("Thread Name: " + thread.Name);
//            Console.WriteLine("Is Background: " + thread.IsBackground);
//            Console.WriteLine("Culture Info: " + thread.CurrentCulture);
//        }
//    }
//}

//using System;
//using System.Diagnostics;
//using System.Threading;

//namespace ConsoleAppMultiThreadingRevision
//{
//    internal class Program
//    {
//        public static void m1()
//        {
//            Console.WriteLine("---m1---");
//            for (int i = 0; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//                Thread.Sleep(500);
//            }
//        }
//        public static void m2()
//        {
//            Console.WriteLine("---m2---");
//            for (int i = 20; i <= 30; i++)
//            {
//                Console.WriteLine(i);
//                Thread.Sleep(500);
//            }
//        }
//        public static void m3()
//        {
//            Console.WriteLine("---m3---");
//            for (int i = 40; i <= 50; i++)
//            {
//                Console.WriteLine(i);
//                Thread.Sleep(500);
//            }
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to Thread");
//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();
//            m1();
//            m2();
//            m3();
//            stopwatch.Stop();
//            Console.WriteLine("Total time take in sec" + stopwatch.Elapsed.TotalSeconds);
//        }
//    }
//}

using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleAppMultiThreadingRevision
{
    internal class Program
    {
        public static void m1()
        {
            Console.WriteLine("---m1---");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
        public static void m2()
        {
            Console.WriteLine("---m2---");
            for (int i = 20; i <= 30; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
        public static void m3()
        {
            Console.WriteLine("---m3---");
            for (int i = 40; i <= 50; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Thread");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread thread = new Thread(m1);
            Thread thread1 = new Thread(m2);
            Thread thread2 = new Thread(m3);
            thread.Start();
            thread1.Start();
            thread2.Start();
            stopwatch.Stop();

            Console.ReadLine();
            Console.WriteLine("Total time take in sec " + stopwatch.Elapsed.TotalSeconds);
            Console.ReadLine();
        }
    }
}

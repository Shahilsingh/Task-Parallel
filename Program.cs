using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Program
    {
     static void test1()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine("Test1:" + i);
        }
        static void test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2:" + i);
                if (i == 50)
                {
                    Console.WriteLine("main thread going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main thred woke up.");
                    
                }
            }
        }
        static void test3()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine("Test3:" + i);
            Console.ReadLine();
        }
        static void Main()
        {
            test1();
            test2();
            test3();
        }


    }
}

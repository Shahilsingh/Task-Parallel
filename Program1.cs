using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Program1
    {
        static void test1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("test1:" + i);
            }
        }
        static void test2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("test2:" + i);
                if (i == 50)
                {
                    Console.WriteLine("thread 2 is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("thread 2 is restart");
                } 
            }
        }
        static void test3()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("test3:" + i);
            }
        }
        static void Main()
        {
            Thread T1 = new Thread(test1);
            Thread T2 = new Thread(test2);
            Thread T3 = new Thread(test3);
            T1.Start(); T2.Start(); T3.Start();
            Console.ReadLine();
        }
    }
}

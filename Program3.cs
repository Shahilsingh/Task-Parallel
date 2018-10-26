using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Program3
    {
        static void Test1()
        {
            for (int i = 1; i <= 25; i++)
                Console.WriteLine("test1:" + i);
            Thread.Sleep(5000);
            Console.WriteLine("test1 is exiting:");
        }
        static void Test2()
        {
            for (int i = 1; i <= 25; i++)
                Console.WriteLine("test2:" + i);
                Console.WriteLine("test2 is exiting:");
        }
        static void Test3()
        {
            for (int i = 1; i <= 25; i++)
                Console.WriteLine("test3:" + i);
            Console.WriteLine("test3 is exiting:");
        }
        static void Main()
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join(3000);t2.Join();t3.Join();
           Console.WriteLine("Main thread exiting:");
            Console.ReadLine();

        }
    }
}

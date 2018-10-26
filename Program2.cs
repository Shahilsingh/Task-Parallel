using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Program2
    {
        private static object T;

        static void Test()
        {
            for(int i = 0;i<100;i++)
            {
                Console.WriteLine(+ i);
            }

        }
        static void Main()
        {
            // ThreadStart obj = new ThreadStart(Test);
            // ThreadStart obj = Test;
             ThreadStart obj = delegate () { Test();};
            

            Thread t = new Thread(obj);
            
            t.Start();
            Console.ReadLine();
        }
    }
}

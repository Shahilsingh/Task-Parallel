using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class program4
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[Csharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented language");
            }
        }
            static void Main()
        {
            program4 obj = new program4();


            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();t2.Start();t3.Start();
            Console.ReadLine();
        }
    }
}

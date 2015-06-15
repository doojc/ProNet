﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AddWithThreads
{
    class Program
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("*** Adding with Thread objects ***");
            Console.WriteLine("ID of thread in Main(): {0}",
                Thread.CurrentThread.ManagedThreadId);

            // Make an AddParams object to pass to the secondary thread.
            AddParams ap = new AddParams(10, 10);

            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);

            // Wait here until you are notified!
            waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");

            Console.ReadLine();

        }

        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add(): {0}",
                    Thread.CurrentThread.ManagedThreadId);

                AddParams ap = (AddParams)data;

                Thread.Sleep(5000);

                Console.WriteLine("{0} + {1} = {2}",
                    ap.a, ap.b, ap.a + ap.b);

                

                // Tell other thread we are done.
                waitHandle.Set();
            }
        }
    }
}

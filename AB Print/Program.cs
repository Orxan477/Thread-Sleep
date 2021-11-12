
using System;
using System.Threading;

namespace AB_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PrintA);
            Thread thread2 = new Thread(PrintB);
            thread1.Start();
            thread2.Start();
        }
        static void PrintA()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"A");
            }
        }
        static void PrintB()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2100);
                Console.WriteLine($"B");
            }
        }

    }
}

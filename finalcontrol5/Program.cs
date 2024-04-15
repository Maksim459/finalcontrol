using System;
using System.Threading;

class Program
{
    static void PrintEvenNumbers()
    {
        for (int i = 0; i <= 1000; i += 2)
        {
            Console.WriteLine($"Even: {i}");
            Thread.Sleep(10); 
        }
    }

    static void PrintOddNumbers()
    {
        for (int i = 1; i <= 1000; i += 2)
        {
            Console.WriteLine($"Odd: {i}");
            Thread.Sleep(10); 
        }
    }

    static void Main()
    {
        Thread evenThread = new Thread(PrintEvenNumbers);
        Thread oddThread = new Thread(PrintOddNumbers);

        evenThread.Start();
        oddThread.Start();

        evenThread.Join();
        oddThread.Join();
    }
}

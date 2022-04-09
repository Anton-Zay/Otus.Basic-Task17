using System;
using System.Diagnostics;

namespace HomeWorkOfLesson17_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 39;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.Write($"Для числа {n} число Фибоначчи равно: {FibboLoop(n)}");
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            Console.WriteLine();
            Console.WriteLine($"Время выполнения задачи циклическим способом: {timeSpan.TotalMilliseconds}");

            Console.WriteLine("---------------------------");

            stopWatch.Restart();
            Console.Write($"Для числа {n} число Фибоначчи равно: {FibboRecurs(n)}");
            stopWatch.Stop();
            timeSpan = stopWatch.Elapsed;
            Console.WriteLine();
            Console.WriteLine($"Время выполнения задачи рекурсивным способом: {timeSpan.TotalMilliseconds}");
        }

        static int FibboRecurs(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            if (n == 2)
            {
                return 1;
            }

            return FibboRecurs(n - 2) + FibboRecurs(n - 1);
        }



        static int FibboLoop(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            if (n == 2)
            {
                return 1;
            }

            int result = 0;
            int prev = 1;
            int prevprev = 0;
            for (int i = 3; i <= n; i++)
            {
                result = prevprev + prev;
                prevprev = prev;
                prev = result;
            }   


            return result;
        }
    }
}
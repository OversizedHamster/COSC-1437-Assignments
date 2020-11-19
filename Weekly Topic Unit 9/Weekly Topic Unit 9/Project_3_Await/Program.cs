using System;
using System.Diagnostics;
using System.Threading.Tasks;

//Ethan Smith

namespace Project_3_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Ethan Smith");
            Console.WriteLine("Weekly Topic Unit 9");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Demo the AwaitDemo1");
                Console.WriteLine("2) Demo the AwaitDemo2");
                Console.WriteLine("X) exit");
                Console.Write("Select demonstration:");

                var keyPressed = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();

                switch (keyPressed)
                {
                    case 'x':
                    case 'X':
                        return;
                    case '1':
                        AwaitDemo1();
                        break;
                    case '2':
                        AwaitDemo2();
                        break;
                }
            }
        }

        static Stopwatch _stopwatch = new Stopwatch();

        private static void AwaitDemo1()
        {
            _stopwatch.Reset();
            _stopwatch.Start();

            Task<string> a = WaitAsynchronouslyAsync(1000);
            Task<string> b = WaitAsynchronouslyAsync(100);
            var c = WaitAsynchronouslyAsync(10);
            var d = WaitAsynchronouslyAsync(2000);
            var e = WaitAsynchronouslyAsync(100);

            Console.WriteLine();

            Console.WriteLine(a.Result);
            Console.WriteLine(b.Result);
            Console.WriteLine(c.Result);
            Console.WriteLine(d.Result);
            Console.WriteLine(e.Result);

            Console.WriteLine();
            Console.WriteLine($"{_stopwatch.ElapsedMilliseconds} total elapsed time");

            _stopwatch.Stop();
        }

        private static void AwaitDemo2()
        {
            _stopwatch.Reset();
            _stopwatch.Start();

            var rnd = new Random();

            var runningTasks = new Task<string>[10];

            for (var taskNumber = 0; taskNumber < 10; taskNumber++)
            {
                runningTasks[taskNumber] = WaitAsynchronouslyAsync(rnd.Next(0, 5000));
            }

            Console.WriteLine();

            for (var taskNumber = 0; taskNumber < 10; taskNumber++)
            {
                Console.WriteLine($"task #{taskNumber} {runningTasks[taskNumber].Result}");
            }

            Console.WriteLine();
            Console.WriteLine($"{_stopwatch.ElapsedMilliseconds} total elapsed time");

            _stopwatch.Stop();
        }

        private static async Task<string> WaitAsynchronouslyAsync(int delay)
        {
            await Task.Delay(delay);
            Console.WriteLine($"Completed tast with {delay} delay ");
            return $"completed {delay} delay in {_stopwatch.ElapsedMilliseconds} milliseconds";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var running = false;

            Console.WriteLine("Welcome to stopwatch! Press 'e' to start/resume, Enter to pause/stop, 'r' to reset, or 'q' to quit.");

            while (true)
            {
                if (running)
                {
                    DisplayElapsedTime(stopwatch);
                }

                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.E)
                    {
                        if (stopwatch.IsRunning)
                        {
                            stopwatch.Stop();
                            running = false;
                            Console.WriteLine($"\nPaused at: {stopwatch.Duration}. Press 'e' to resume, Enter to stop.");
                        }
                        else
                        {
                            stopwatch.Start();
                            running = true;
                            Console.WriteLine("\nStopwatch started. Press Enter to pause.");
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        if (stopwatch.IsRunning)
                        {
                            stopwatch.Stop();
                            running = false;
                            Console.WriteLine($"\nStopped at: {stopwatch.Duration}. Press 'e' to start again, 'r' to reset, or 'q' to quit.");
                        }
                        else
                        {
                            Console.WriteLine("\nStopwatch is not running. Press 'e' to start or 'q' to quit.");
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.R)
                    {
                        stopwatch.Reset();
                        running = false;
                        Console.WriteLine("\nStopwatch reset. Press 'e' to start, 'q' to quit.");
                    }
                    else if (keyInfo.Key == ConsoleKey.Q)
                    {
                        Console.WriteLine("\nExiting the stopwatch. Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid key. Press 'e' to start/resume, Enter to pause/stop, 'r' to reset, or 'q' to quit.");
                    }
                }

                Thread.Sleep(5);
            }
        }

        static void DisplayElapsedTime(Stopwatch stopwatch)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan elapsed = DateTime.Now - stopwatch.StartTime;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"Elapsed Time: {elapsed:hh\\:mm\\:ss\\.fff}");
            }
        }
    }
}
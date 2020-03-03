using System;

namespace Mosh_Exercise1
{

    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("Start timer");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Stop timer");
            timer.Stop();
            var test = Stopwatch.GetDuration();
            Console.WriteLine("Time passed: ", test);
        }
    }
}

using System;
using System.Timers;

namespace Mosh_Exercise1
{
    public class Stopwatch
    {
        private static Timer _timer = new Timer(1000);
        private static DateTime _startTime;
        private static DateTime _endTime;
        private bool _isRunning;

        public void Start()
        {
            _isRunning = true;
            _startTime = DateTime.Now;
            _timer.Start();
            _timer.Elapsed += OnTimedEvent;
            // TODO: you can't run this two times in a row.
            if (_isRunning == true)
                Console.WriteLine("You can't call this.");
        }

        public void Stop()
        {
            _isRunning = false;
            _timer.Stop();
            _timer.Dispose();
            _endTime = DateTime.Now;
        }

        public static TimeSpan GetDuration()
        {
            var result = _endTime - _startTime;
            return result;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }
    }
}

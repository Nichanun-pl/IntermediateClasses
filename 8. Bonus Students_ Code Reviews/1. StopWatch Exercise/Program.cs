using System;
using System.Threading;

namespace CSharpInTermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (int i = 0; i < 2; i++)
            {
                stopwatch.start(DateTime.Today.AddDays(1));

                for (int j = 0; j < 1000; j++)
                {
                    Thread.Sleep(1);
                }

                //stopwatch.Start(DateTime.Now);

                stopwatch.stop(DateTime.Today.AddYears(-1));

                Console.WriteLine(stopwatch.GetInterval().ToString());
                Console.ReadLine();
            }
        }
    }
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _running;

        public void start(DateTime start)
        {
            if (!_running)
            {
                _startTime = start;
                _running = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
        }
        public void stop(DateTime stop)
        {
            if (_running)
            {
                _endTime = stop;
                _running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            var duration = _endTime - _startTime;
            return duration;
        }
    }
}

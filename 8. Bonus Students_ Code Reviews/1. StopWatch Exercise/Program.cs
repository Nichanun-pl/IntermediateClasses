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

        public void start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is already running");
            
            _startTime = DateTime.Now;
            _running = true;
        }

        public void stop()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is not running");
            {
                _endTime = DateTime.Now;
                _running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            return duration;
        }
    }
}

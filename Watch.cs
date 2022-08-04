using System.Diagnostics;
namespace StopWatch
{
    class Watch
    {
        public static void Main()
        {
            Stopwatch swatch = new Stopwatch();
            TimeSpan tspan = new TimeSpan();

            Console.Write("Press any key to start : ");
            Console.ReadKey();
            swatch.Start();

            Console.WriteLine(" \nStopwatch Started ");
            Console.Write("Press any key stop : ");
            Console.ReadKey();
            swatch.Stop();

            tspan = swatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",tspan.Hours, tspan.Minutes, tspan.Seconds);

            Console.WriteLine("\nElpased time is : "+elapsedTime);
        }
    }
}
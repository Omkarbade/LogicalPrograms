using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public static void GetElapsedTime()
        {
            //Object of Stopwatch class
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Hit Enter to start the Watch");
            Console.ReadLine();
            stopWatch.Start();    //Timer started
            Thread.Sleep(6000);  //pause for 6 second
            Console.WriteLine("Hit Enter to stop the Watch");
            Console.ReadLine();
            stopWatch.Stop();   //Timer stopped

            TimeSpan ts = stopWatch.Elapsed; // Get the elapsed time as a TimeSpan value

            // Format and display the TimeSpan value
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}

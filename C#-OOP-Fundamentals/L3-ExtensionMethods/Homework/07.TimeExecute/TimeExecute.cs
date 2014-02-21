/*
 * Using delegates write a class Timer that has can execute certain method at each t seconds.
 */


namespace _07.TimeExecute
{
    using System;
    using System.Threading;
    public class TimeExecute
    {
        public static void Main()
        {
            TimerEvent te1 = new TimerEvent(ExecuteEach3Seconds);
            Timer tm1 = new Timer(3, te1);

            TimerEvent te2 = new TimerEvent(SecondExecuteEach5Seconds);
            Timer tm2 = new Timer(5, te2);

            Timer tm3 = new Timer(new TimerEvent(delegate() { Console.WriteLine("One"); }));

            Thread timer1Thread = new Thread(new ThreadStart(tm1.Run));
            timer1Thread.Start();

            Thread timer2Thread = new Thread(new ThreadStart(tm2.Run));
            timer2Thread.Start();

            Thread timer3Thread = new Thread(new ThreadStart(tm3.Run));
            timer3Thread.Start();
        }
        private static void ExecuteEach3Seconds()
        {
            Console.WriteLine("Three");
        }

        private static void SecondExecuteEach5Seconds()
        {
            Console.WriteLine("Five");
        }
    }
}

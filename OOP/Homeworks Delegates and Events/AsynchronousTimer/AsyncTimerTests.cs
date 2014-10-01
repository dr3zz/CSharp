namespace AsynchronousTimer
{
    using System;

    class AsyncTimerTests
    {
        public static void Print()
        {
            Console.Write("Tick: ");
        }

        public static void BeeP()
        {
            
            Console.Beep();
            Console.Write("Beep: ");
        }

        static void Main(string[] args)
        {
            AsyncTimer print = new AsyncTimer(Print, 10, 1000);
            print.Start();
            AsyncTimer beep = new AsyncTimer(BeeP, 10, 500);
            beep.Start();
        }
    }
}

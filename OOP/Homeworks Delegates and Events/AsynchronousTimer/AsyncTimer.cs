namespace AsynchronousTimer
{
    using System;
    using System.Threading;

    internal class AsyncTimer
    {
        private Action method;

        private int ticks;

        private int interval;

        public AsyncTimer(Action method, int ticks, int interval)
        {
            this.method = method;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                this.ticks = value;
            }
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                this.interval = value;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.Work);
            thread.Start();
        }

        private void Work()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);
                this.method();
                Console.WriteLine(this.ticks);
                this.Ticks--;
            }
        }
    }
}
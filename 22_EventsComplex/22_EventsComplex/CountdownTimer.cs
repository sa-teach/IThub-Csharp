using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;

namespace _22_EventsComplex
{
    internal class CountdownTimer
    {
        private int IntervalSeconds = 1; // интервал между тиками в секундах
        public int InitialTime { get; set; }

        private event EventHandler<int>? tickChanged;
        public event EventHandler<int>? Tick
        {
            add
            {
                Console.WriteLine("Подписка на событие оформлена.");
                tickChanged += value;
            }
            remove
            {
                Console.WriteLine("Подписка на событие отменена.");
                tickChanged -= value;
            }
        }

        private event EventHandler? finishedChanged;
        public event EventHandler? Finished
        {
            add
            {
                Console.WriteLine($"Подписка на событие оформлена.");
                finishedChanged += value;
            }
            remove
            {
                Console.WriteLine("Подписка на событие отменена.");
                finishedChanged -= value;
            }
        }

        public void Start(int seconds)
        {
            InitialTime = seconds;
            for (int i = seconds; i > 0; i--)
            {
                tickChanged?.Invoke(this, i);
                Thread.Sleep(IntervalSeconds * 1000);
            }
            finishedChanged?.Invoke(this, EventArgs.Empty);
        }
    }

}

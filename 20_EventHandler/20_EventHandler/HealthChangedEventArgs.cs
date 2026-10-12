using System;
using System.Collections.Generic;
using System.Text;

namespace _20_EventHandler
{
    internal class HealthChangedEventArgs: EventArgs
    {
        public int OldHealth { get; }
        public int NewHealth { get; }
        public HealthChangedEventArgs(int oldHealth, int newHealth)
        {
            OldHealth = oldHealth;
            NewHealth = newHealth;
        }
    }
}

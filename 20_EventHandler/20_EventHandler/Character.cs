using System;
using System.Collections.Generic;
using System.Text;

namespace _20_EventHandler
{
    internal class Character
    {
        private EventHandler<HealthChangedEventArgs>? changed;
        public event EventHandler<HealthChangedEventArgs>? HealthChanged
        {
            add
            {
                Console.WriteLine("Новая подписка на HealthChanged");
                changed += value;
            }
            remove
            {
                Console.WriteLine("Подписка на HealthChanged снята");
                changed -= value;
            }
        }
        private int Health = 100;
        public void TakeDamage()
        {
            int value = 101;
            if (Health == 0)
            {
                Console.WriteLine("Персонаж мёртв! :(");
                Environment.Exit(0);
            }
            Console.Write("Введите силу атаки: ");
            while (value > Health)
            {
                value = Logic.SafeInputInt();
                if (value > Health) Console.WriteLine("У персонажа нет столько HP!");
            }
            int old = Health;
            Health -= value;
            changed?.Invoke(this, new HealthChangedEventArgs(old, Health));
        }
    }
}


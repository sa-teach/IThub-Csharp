using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _21_Variability
{
    internal class Character
    {
        public virtual string Name => "Персонаж";
        public Character() => Console.WriteLine("Персонаж создан!");

    }
}

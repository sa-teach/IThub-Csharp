using System;
using System.Collections.Generic;
using System.Text;

namespace _24_ConstrainedClasses
{
    internal class Potion : Item
    {
        public override string GetDescription() => $"Зелье с эффектом {Name} +{(int)Value/10}";
        public Potion(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
    }
}

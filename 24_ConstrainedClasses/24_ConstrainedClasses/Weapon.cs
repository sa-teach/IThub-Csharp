using System;
using System.Collections.Generic;
using System.Text;

namespace _24_ConstrainedClasses
{
    internal class Weapon : Item
    {
        public override string GetDescription() => $"Оружие {Name}, наносящее урон -{(int)Value / 10}";
        public Weapon(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _23_ConstrainedTypes
{
    internal class Player : IComparable<Player>
    {
        public string Name;
        public int Points;
        public int CompareTo(Player other) => Points.CompareTo(other.Points);
        public override string ToString() => Name;

        public static T FindBest<T>(List<T> items) where T : IComparable<T>
        {
            T max = items[0];
            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0) max = item;
            }
            return max;
        }
        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }
    }
}


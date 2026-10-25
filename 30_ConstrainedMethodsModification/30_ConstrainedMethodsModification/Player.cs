using System;
using System.Collections.Generic;
using System.Text;

namespace _30_ConstrainedMethodsModification
{
    internal class Player : IComparable<Player>
    {
        public string Name;
        public int Score;
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString() => $"{Name}: {Score}";
        public int CompareTo(Player other) => this.Score.CompareTo(other.Score);
    }
}

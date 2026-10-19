using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _24_ConstrainedClasses
{
    internal abstract class Item
    {
        public string Name { get; init; }
        public decimal Value { get; init; }
        public abstract string GetDescription();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _29_Constrained_Interfaces
{
    internal class Product: IEntity
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public override string ToString() => $"ID: {Id}, продукт: {Name}, цена: {Price} у.е.";
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}

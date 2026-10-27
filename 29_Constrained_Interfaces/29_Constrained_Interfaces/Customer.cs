using System;
using System.Collections.Generic;
using System.Text;

namespace _29_Constrained_Interfaces
{
    internal class Customer : IEntity
    {
        public int Id { get; }
        public string Name { get; }
        public double Balance { get; }
        public override string ToString() => $"ID: {Id}, покупатель: {Name}, баланс: {Balance} у.е.";
        public Customer(int id, string name, double balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
    }
}

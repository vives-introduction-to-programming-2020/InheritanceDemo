using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public class Consumable
    {
        public Consumable(String description, double price)
        {
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Description}: {Price}eur";
        }

        public String Description { get; private set; }
        public double Price { get; private set; }
    }
}

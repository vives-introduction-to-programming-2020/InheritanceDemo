using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public class Drink : Consumable
    {
        public Drink(String description) : base(description, 1.40)
        {
        }
    }
}

using System;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base class: Consumable
            // Subclass: Fries, Drink, ...

            Consumable cola = new Consumable("Nice fresh cola", 1.10);
            Fries myFries = new Fries(true);
            Fries myWifesFries = new Fries(false);

            List<Fries> allFries = new List<Fries>();
            // List<Drink> allDrinks = new List<Drink>();
            // List<Boulet> allBoulets = new List<Boulet>();

            List<Consumable> list = new List<Consumable>();
            list.Add(new Fries(true));
            list.Add(new Fries(true));
            list.Add(new Fries(false));
            list.Add(new Drink("Nice fresh cola"));

            double totalPrice = 0;
            foreach (var item in list)
            {
                totalPrice += item.Price;
                Console.WriteLine(item);
            }

            Console.WriteLine("TOTAL = " + totalPrice);

        }
    }
}

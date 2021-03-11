using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public class Fries : Consumable
    {
        public Fries(bool withSalt) : base("Package of fries", 1.34)
        {
            WithSalt = withSalt;
        }

        public override string ToString()
        {
            if (WithSalt)
            {
                return $"{Description} with salt: {Price}";
            }

            return base.ToString();
        }

        public bool WithSalt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Designmönster.Drinks.Water
{
    // Implementerar en specifik varm dryck, i detta fall vatten
    internal class Water : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm water is served."); // Utskrift vid konsumtion av vatten
        }
    }
}

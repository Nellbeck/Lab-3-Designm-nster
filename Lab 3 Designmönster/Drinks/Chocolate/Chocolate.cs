using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Designmönster.Drinks.Chocolate
{
    internal class Chocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Chocolate is served."); // Utskrift vid konsumtion av choklad
        }
    }
}

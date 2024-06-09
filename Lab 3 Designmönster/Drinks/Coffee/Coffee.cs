using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Designmönster.Drinks.Coffee
{
    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Coffee is served."); // Utskrift vid konsumtion av kaffe
        }
    }
}

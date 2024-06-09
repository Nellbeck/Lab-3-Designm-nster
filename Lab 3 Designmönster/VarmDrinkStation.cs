using Lab_3_Designmönster.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3_Designmönster 
{ 

    class VarmDrinkStation
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine(); // Skapar en instans av WarmDrinkMachine
            IWarmDrink drink = machine.MakeDrink(); // Skapar en dryck
            drink.Consume(); // Konsumerar drycken
        }
    }
}


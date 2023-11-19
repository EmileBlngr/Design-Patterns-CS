using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Method
{
    internal class Program
    {
        static void Main()
        {
            //pizza simple
            IComposantPizza pizzaSimple = new PizzaSimple();
            Console.WriteLine($"Description: {pizzaSimple.Description()}");
            Console.WriteLine($"Prix: {pizzaSimple.CalculerPrix()}");

            // Ajouter du fromage à la pizza
            IComposantPizza pizzaFromage = new FromageDecorator(pizzaSimple);
            Console.WriteLine($"Description: {pizzaFromage.Description()}");
            Console.WriteLine($"Prix: {pizzaFromage.CalculerPrix()}");

            // Ajouter des champignons à la pizza
            IComposantPizza pizzaChampignons = new ChampignonsDecorator(pizzaFromage);
            Console.WriteLine($"Description: {pizzaChampignons.Description()}");
            Console.WriteLine($"Prix: {pizzaChampignons.CalculerPrix()}");
        }
    }
}

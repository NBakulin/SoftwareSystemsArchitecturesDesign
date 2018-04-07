using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorExample.Margherita pizza1 = new DecoratorExample.Margherita();
            Console.WriteLine("Маргарита: " + pizza1.GetPrice().ToString());

            DecoratorExample.ExtraCheeseTopping moreCheese = new DecoratorExample.ExtraCheeseTopping(pizza1);
            Console.WriteLine("Маргарита с сыром: " + moreCheese.GetPrice().ToString());

            DecoratorExample.ExtraCheeseTopping someMoreCheese = new DecoratorExample.ExtraCheeseTopping(moreCheese);
            Console.WriteLine("Маргарита с двойным сыром: " + someMoreCheese.GetPrice().ToString());

            DecoratorExample.MushroomTopping moreMushroom = new DecoratorExample.MushroomTopping(someMoreCheese);
            Console.WriteLine("Маргарита с двойным сыром и грибами: " + moreMushroom.GetPrice().ToString());

            DecoratorExample.JalapenoTopping moreJalapeno = new DecoratorExample.JalapenoTopping(moreMushroom);
            Console.WriteLine("Маргарита с двойным сыром, халапеньо и грибами: " + moreJalapeno.GetPrice().ToString());

            DecoratorExample.Gourmet pizza2 = new DecoratorExample.Gourmet();
            Console.WriteLine("Гурме: " + pizza2.GetPrice().ToString());

            moreJalapeno = new DecoratorExample.JalapenoTopping(pizza2);
            Console.WriteLine("Гурме с халапеньо: " + moreJalapeno.GetPrice().ToString());

            Console.ReadLine();
        }
    }
}

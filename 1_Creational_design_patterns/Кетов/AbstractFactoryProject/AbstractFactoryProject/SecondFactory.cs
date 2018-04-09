using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    class SecondFactory:IFactory
    {
        private ulong budget;
        public ulong Budget
        {
            get
            {
                return budget;
            }


        }

        public IChocolate CreateChocolate()
        {
            IChocolate returningChocolate = new Snikers(300, 6000, 4000);
            budget += returningChocolate.Price - returningChocolate.Cost;
            return returningChocolate;
        }

        public IDrink CreateDrink()
        {
            IDrink returningDrink = new Fanta(1000, 7000, 3700);
            budget += returningDrink.Price - returningDrink.Cost;
            return returningDrink;
        }
        public void PrintBudget()
        {
            Console.WriteLine("Бюджет второй фабрики:" + budget);
        }
        public SecondFactory(ulong _budget)
        {
            budget = _budget;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    class FirstFactory : IFactory
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
            IChocolate returningChocolate = new Mars(200, 5000, 3500);
            budget += returningChocolate.Price - returningChocolate.Cost;
            return returningChocolate;
        }

        public IDrink CreateDrink()
        {
            IDrink returningDrink = new Cola(500, 4000, 3700);
            budget += returningDrink.Price - returningDrink.Cost;
            return returningDrink;
        }
        public void PrintBudget()
        {
            Console.WriteLine("Бюджет первой фабрики" + budget);
        }
        public FirstFactory(ulong _budget)
        {
            budget = _budget;
        }
    }
}

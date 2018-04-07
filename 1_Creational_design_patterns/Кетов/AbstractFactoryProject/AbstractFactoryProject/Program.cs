using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFactory = new FirstFactory(100000);
            var secondFactory = new SecondFactory(100000);
            var firstFirstFactoryClient = new Client(firstFactory, "Dima", 13000);
            var secondFirstFactoryClient = new Client(firstFactory, "Vova", 13000);
            var firstSecondFactoryClient = new Client(secondFactory, "Vasya" , 500000);
            var secondSecondFactoryClient = new Client(secondFactory,"Oleg", 5000000);

            firstFirstFactoryClient.BuyChocolate();
            firstFirstFactoryClient.BuyDrink();
            firstFactory.PrintBudget();
            secondFirstFactoryClient.BuyChocolate();
            firstFactory.PrintBudget();
            firstSecondFactoryClient.BuyChocolate();
            firstSecondFactoryClient.BuyDrink();
            secondFactory.PrintBudget();
            secondSecondFactoryClient.BuyChocolate();
            secondFactory.PrintBudget();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    interface IFactory
    {
        IChocolate CreateChocolate();
        IDrink CreateDrink();

        ulong Budget
        {
            get; 
        }
        void PrintBudget();
    }
}

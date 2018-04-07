using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    class Client
    {
        //Поля
        private IFactory factory;
        public IFactory Factory
        {
            get
            {
                return factory;
            }
            set
            {
                factory = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <= 20)
                    name = value;
                else throw new Exception("Name is too long");
            }
        }

        private ulong budget;
        public ulong Budget
        {
            get
            {
                return budget;
            }
            set
            {
                budget = value;
            }
        }

        private List<IChocolate> chocolates = new List<IChocolate>();
        public List<IChocolate> Chocolates
        {
            get
            {
                return chocolates;
            }
            set
            {
                chocolates = value;
            }
        }

        private List<IDrink> drinks = new List<IDrink>();
        public List<IDrink> Drinks
        {
            get
            {
                return drinks;
            }
            set
            {
                drinks = value;
            }
        }
        

        //Методы
        public void PrintBudget()
        {
            Console.WriteLine(budget);
        }

        public void BuyChocolate()
        {
            var chocolate = factory.CreateChocolate();
            budget -= chocolate.Price;
            chocolate.Print();
            chocolates.Add(chocolate);
        }
        public void BuyDrink()
        {
            var drink = factory.CreateDrink();
            budget -= drink.Price;
            drink.Print();
            drinks.Add(drink);
        }

        public Client(IFactory _factory, string _name = "", ulong _budget = 0 )
        {
            factory = _factory;
            name = _name;
            budget = _budget;
        }
    }
}

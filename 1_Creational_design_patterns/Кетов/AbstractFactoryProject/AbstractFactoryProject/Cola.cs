using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    class Cola : IDrink
    {
        private ulong cost;
        public ulong Cost
        {
            get
            {
                return cost;
            }
        }


        private string name="Cola";
        public string Name
        {
            get
            {
                return name;
            }
        }

        private ulong price;
        public ulong Price
        {
            get
            {
                return price;
            }
        }

        private double size;
        public double Size
        {
            get
            {
                return size;
            }
        }

        public void Print()
        {
            Console.WriteLine("*Вызвано из класса Cola*"+ size + " " + name);
        }
        public Cola(double _size, ulong _price, ulong _cost)
        {
            size = _size;
            price = _price;
            cost = _cost;
        }
    }
}

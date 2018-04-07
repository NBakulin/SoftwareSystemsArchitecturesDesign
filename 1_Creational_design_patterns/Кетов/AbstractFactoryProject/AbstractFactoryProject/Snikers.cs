using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    class Snikers : IChocolate
    {
        private ulong cost = 3000;
        public ulong Cost
        {
            get
            {
                return cost;
            }
        }

        private string name = "Snikers";
        public string Name
        {
            get
            {
                return name;
            }
        }

        private ulong price = 5000;
        public ulong Price
        {
            get
            {
                return price;
            }
        }

        public double size = 200;
        public double Size
        {
            get
            {
                return size;
            }
        }

        public string type = "Батончик";
        public string Type
        {
            get
            {
                return type;
            }
        }

        public void Print()
        {
            Console.WriteLine("*Вызвано из класса Snikers*" + type + " " + name);
        }
        public Snikers(double _size, ulong _price, ulong _cost)
        {
            size = _size;
            price = _price;
            cost = _cost;
        }
    }
}

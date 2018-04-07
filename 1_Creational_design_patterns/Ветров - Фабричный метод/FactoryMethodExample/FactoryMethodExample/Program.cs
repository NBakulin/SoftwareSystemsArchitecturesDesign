using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    abstract class DairyProduct
    {
        protected double fatness;
        protected bool liquid;
        public abstract string GetName();
        public abstract string WayToMake();
        public virtual double GetFatness()
        {
            return fatness;
        }
        public virtual void SetFatness(double f)
        {
            fatness = f;
        }
        public virtual void SetLiquid(bool l)
        {
            liquid = l;
        }
        public virtual string GetLiquid()
        {
            if (liquid)
                return "Жидкий";
            else
                return "Твердый";
        }
    }
    class MilkProduct : DairyProduct
    {
        
        public override string GetName()
        {
            return "Молоко";
        }

        public override string WayToMake()
        {
            return "Корову доят, продукт пастеризуется";
        }
    }
    class CheaseProduct : DairyProduct
    {
        public override string GetName()
        {
            return "Сыр";
        }
        public override string WayToMake()
        {
            return "Плавления различных молочных продуктов";
        }
    }
    class ButterProduct : DairyProduct
    {
        public override string GetName()
        {
            return "Масло";
        }

        public override string WayToMake()
        {
            return "Взбивание сметаны";
        }
    }
    class YogurtProduct : DairyProduct
    {
        public override string GetName()
        {
            return "Йогурт";
        }

        public override string WayToMake()
        {
            return "Сбраживание кисломолочных продуктов";
        }
    }
    abstract class DairyCreator
    {
        public abstract DairyProduct FactoryMethod();
    }
    class MilkCreator : DairyCreator
    {
        public override DairyProduct FactoryMethod()
        {
            return new MilkProduct();
        }
    }
    class CheaseCreator : DairyCreator
    {
        public override DairyProduct FactoryMethod()
        {
            return new CheaseProduct();
        }
    }
    class ButterCreator : DairyCreator
    {
        public override DairyProduct FactoryMethod()
        {
            return new ButterProduct();
        }
    }
    class YogurtCreator : DairyCreator
    {
        public override DairyProduct FactoryMethod()
        {
            return new YogurtProduct();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DairyCreator[] creators = {
                new MilkCreator(),
                new CheaseCreator(),
                new ButterCreator(),
                new YogurtCreator()
            };
            foreach (DairyCreator cr in creators)
            {
                Console.WriteLine();
                DairyProduct dP = cr.FactoryMethod();
                Console.WriteLine("Создан: " + dP.GetName());
                switch(dP.GetName())
                {
                    case "Молоко":
                        dP.SetFatness(3.5);
                        dP.SetLiquid(true);
                        break;
                    case "Сыр":
                        dP.SetFatness(55.5);
                        dP.SetLiquid(false);
                        break;
                    case "Масло":
                        dP.SetFatness(75.5);
                        dP.SetLiquid(false);
                        break;
                    case "Йогурт":
                        dP.SetFatness(2.5);
                        dP.SetLiquid(true);
                        break;
                }
                Console.WriteLine("Жирность: " + dP.GetFatness());
                Console.WriteLine("Состояние: " + dP.GetLiquid());
                Console.WriteLine("Способ приготовления: " + dP.WayToMake());
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}

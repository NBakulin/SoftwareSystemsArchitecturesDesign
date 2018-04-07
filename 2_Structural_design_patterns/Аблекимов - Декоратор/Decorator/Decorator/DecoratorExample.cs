using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DecoratorExample
    {
        public abstract class Pizza
        {
            protected double price;

            public virtual double GetPrice()
            {
                return this.price;
            }
        }

        public class Margherita : Pizza
        {
            public Margherita()
            {
                this.price = 6.99;
            }
        }

        public class Gourmet : Pizza
        {
            public Gourmet()
            {
                this.price = 8.49;
            }
        }

        public abstract class ToppingsDecorator : Pizza
        {
            protected Pizza pizza;
            public ToppingsDecorator(Pizza pizzaToDecorate)
            {
                this.pizza = pizzaToDecorate;
            }

            public override double GetPrice()
            {
                return (this.pizza.GetPrice() + this.price);
            }
        }
       
        public class ExtraCheeseTopping : ToppingsDecorator
        {
            public ExtraCheeseTopping(Pizza pizzaToDecorate)
                : base(pizzaToDecorate)
            {
                this.price = 0.99;
            }
        }

        public class MushroomTopping : ToppingsDecorator
        {
            public MushroomTopping(Pizza pizzaToDecorate)
                : base(pizzaToDecorate)
            {
                this.price = 1.49;
            }
        }

        public class JalapenoTopping : ToppingsDecorator
        {
            public JalapenoTopping(Pizza pizzaToDecorate)
                : base(pizzaToDecorate)
            {
                this.price = 1.49;
            }
        }
    }
}

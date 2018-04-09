using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ClientCode
    {
        private IProductA productA;
        private IProductB productB;

        public ClientCode(IAbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void WriteNameAndType()
        {
            productA.WriteNameAndType();
        }

        public void WriteNumber()
        {
            productB.WriteNumber();
        }
    }
}

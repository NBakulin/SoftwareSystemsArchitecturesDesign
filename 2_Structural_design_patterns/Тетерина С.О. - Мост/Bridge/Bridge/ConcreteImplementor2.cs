using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImplementor2:Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("this is another implementor, ConcreteImplementor2");
        }
    }
}

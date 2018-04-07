using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImplementor1:Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("this is ConcreteImplementor1");
        }
    }
}

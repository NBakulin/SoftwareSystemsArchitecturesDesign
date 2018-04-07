using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementor1();
            ab.Operation();

            // Change implementation and call
            ab.Implementor = new ConcreteImplementor2();
            ab.Operation();

            // Wait for user
            Console.ReadLine();
        }
    }
}

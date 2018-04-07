using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Начальная инициализация с первым вариантом реализации
            
            RefinedAbstracion refinedAbstraction = new RefinedAbstracion(new ConcretteImplementorA());
            refinedAbstraction.Operation();
            //Изменяем используемый вариант реализации
            refinedAbstraction.Implementor = new ConcretteImplementorB();
            refinedAbstraction.Operation();
            Console.ReadKey();
        }
    }

    //базовый класс абстракции
    abstract class Abstraction
    {
        private Implementor _imp;
        public Implementor Implementor { set { _imp = value; } }
        public Abstraction(Implementor implementor)
        {
            _imp = implementor;
        }
        public virtual void Operation()
        {
            _imp.OperationImp();
        }
    }
    //класс уточненной абстракции
    class RefinedAbstracion : Abstraction
    {
        public RefinedAbstracion(Implementor implementor) : base(implementor)
        { }
        public override void Operation()
        {
            base.Operation();
        }
    }

    //Интерфейс реализации
    interface Implementor
    {
        void OperationImp();
    }

    class ConcretteImplementorA : Implementor
    {
        public void OperationImp()
        {
            Console.WriteLine("Первый вариант реализации");
            int a = 3, b = 9, c;
            c = a / b;
            Console.WriteLine(c);
        }
    }

    class ConcretteImplementorB : Implementor
    {
        public void OperationImp()
        {
            Console.WriteLine("Второй вариант реализации");
            double a=3, b=9,c;
            c = a / b;
            Console.WriteLine(c);
        }
    }
}

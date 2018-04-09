using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        /*
         * Вывод
         * Name: ProductA. Type:1
         * 1
         * 2
         */
        static void Main(string[] args)
        {
            ClientCode cc = new ClientCode(new Factory1());
            cc.WriteNameAndType();
            cc.WriteNumber();

            ClientCode cc2 = new ClientCode(new Factory2());
            cc2.WriteNumber();
        }
    }
}

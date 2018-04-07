using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    class ConsoleWriter:IWriter
    {
        public void Clear()
        {

        }
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}
